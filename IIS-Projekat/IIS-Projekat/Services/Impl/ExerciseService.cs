using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using Microsoft.EntityFrameworkCore;
using IIS_Projekat.SupportClasses.Roles;

namespace IIS_Projekat.Services.Impl
{
    public class ExerciseService : IExerciseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExerciseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
        }

        public long CreateExercise(NewExerciseDTO newExerciseDTO, string email)
        {
            Exercise newExercise = new Exercise();
            if(_unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == newExerciseDTO.Name).FirstOrDefault() != null)
            {
                throw new ArgumentException("Exercise with given name already exists in the database!");
            }
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();

            newExercise.Name = newExerciseDTO.Name;
            newExercise.IsHypertrophic = (user.Role == Roles.Trainer) ? true : false;
            AddPrimaryMuscleGroup(newExercise, newExerciseDTO.PrimaryMuscleGroup);
            AddSecondaryMuscleGroups(newExercise, newExerciseDTO.SecondaryMuscleGroups);
            newExercise = _unitOfWork.ExerciseRepository.Create(newExercise);
            _unitOfWork.SaveChanges();
            return newExercise.Id;
        }

        public PaginationWrapper<PreviewExerciseDTO> GetSuitableExercisesForClient(long clientId)
        {
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == clientId).FirstOrDefault();
            if(medicalRecord == null)
            {
                throw new NotFoundException($"Client with ID: {clientId} does not have a medical record.");
            }
            HashSet<MuscleGroup> lowSeverityInjuries = new HashSet<MuscleGroup>();
            HashSet<MuscleGroup> highSeverityInjuries = new HashSet<MuscleGroup>();

            ICollection<InjuryTherapy> clientInjuries = _unitOfWork.InjuryTherapyRepository.GetAll(it => it.Injury, it => it.Therapy, it => it.Therapy.MedicalRecord).Where(it => it.Therapy.MedicalRecord == medicalRecord).ToList();
            
            clientInjuries.ToList().ForEach(injuryMR => {
                var injury = _unitOfWork.InjuryRepository.GetById(injuryMR.Injury.Id, i => i.Muscle);
                if (injuryMR.InjurySeverity == "Low") lowSeverityInjuries.Add(injury.Muscle);
                else highSeverityInjuries.Add(injury.Muscle);
            });

            ICollection<Exercise> primarilyInjured = GetHypertrophyExercisesWithPrimaryMuscleGroups(lowSeverityInjuries);
            ICollection<Exercise> secondarilyInjured = GetHypertrophyExercisesWithMuscleGroups(highSeverityInjuries);
            ICollection<Exercise> unnecessaryRehabilitationalExercises = GetUnnecessaryRehabilitationalExercises(highSeverityInjuries);
            ICollection<Exercise> suitableExercises = _unitOfWork.ExerciseRepository.GetAll(e => e.ExercisesMG)
                .ToHashSet().Except(primarilyInjured).Except(secondarilyInjured).Except(unnecessaryRehabilitationalExercises).ToList();

            return new PaginationWrapper<PreviewExerciseDTO>(_mapper.Map<List<PreviewExerciseDTO>>(suitableExercises), suitableExercises.Count);
        }

        public PaginationWrapper<PreviewExerciseDTO> GetAll(PaginationQuery? paginationQuery)
        {

            var paginationResult = _unitOfWork.ExerciseRepository.Filter(paginationQuery);
            return new PaginationWrapper<PreviewExerciseDTO>(_mapper.Map<List<PreviewExerciseDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public PaginationWrapper<PreviewExerciseDTO> GetRehabilitationExercises(PaginationQuery? paginationQuery)
        {
            paginationQuery.Filters.Add(new Filter
            {
                Property = "IsHypertrophic", 
                FilterValues = new List<Filter.FilterValue> 
                { 
                    new Filter.FilterValue
                    {
                        Value = "false",
                        Operation = FilterOperation.NumberEquals
                    }
                }
            });
            var paginationResult = _unitOfWork.ExerciseRepository.Filter(paginationQuery);
            return new PaginationWrapper<PreviewExerciseDTO>(_mapper.Map<List<PreviewExerciseDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public void DeleteExercise(long id)
        {
            Exercise exercise = _unitOfWork.ExerciseRepository.GetById(id);
            if (exercise == null)
            {
                throw new NotFoundException("Exercise with given ID does not exist in the database!");
            }
            if (exercise.IsDeleted)
            {
                throw new ArgumentException("Exercise with given ID is already deleted.");
            }

            exercise.IsDeleted = true;
            exercise.ModifiedDate = DateTime.UtcNow;
            _unitOfWork.SaveChanges();
        }

        private void AddPrimaryMuscleGroup(Exercise exercise, string muscleGroup)
        {
            var primaryMuscleGroup = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == muscleGroup).FirstOrDefault();
            if (primaryMuscleGroup == null)
            {
                throw new ArgumentException($"Invalid primary muscle group: {muscleGroup}.");
            }
            ExerciseMuscleGroup exerciseMuscleGroup = new ExerciseMuscleGroup();
            exerciseMuscleGroup.Exercise = exercise;
            exerciseMuscleGroup.MuscleGroup = primaryMuscleGroup;
            exerciseMuscleGroup.IsPrimaryMuscleGroup = true;
            exerciseMuscleGroup = _unitOfWork.ExerciseMuscleGroupRepository.Create(exerciseMuscleGroup);
        }

        private void AddSecondaryMuscleGroups(Exercise exercise, ICollection<string> muscleGroup)
        {
            muscleGroup.ToList().ForEach(mgName =>
            {
                var secondaryMuscleGroup = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == mgName).FirstOrDefault();
                if (secondaryMuscleGroup == null)
                {
                    throw new ArgumentException($"Invalid secondary muscle group: {mgName}.");
                }
                ExerciseMuscleGroup exerciseMuscleGroup = new ExerciseMuscleGroup();
                exerciseMuscleGroup.Exercise = exercise;
                exerciseMuscleGroup.MuscleGroup = secondaryMuscleGroup;
                exerciseMuscleGroup.IsPrimaryMuscleGroup = false;
                exerciseMuscleGroup = _unitOfWork.ExerciseMuscleGroupRepository.Create(exerciseMuscleGroup);
            });
        }

        private ICollection<Exercise> GetHypertrophyExercisesWithPrimaryMuscleGroups(HashSet<MuscleGroup> injuredMuscleGroups)
        {
            ICollection<Exercise> exercises = new List<Exercise>();
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise).Where(emg => injuredMuscleGroups.Contains(emg.MuscleGroup) && emg.IsPrimaryMuscleGroup == true && emg.Exercise.IsHypertrophic == true).ToList()
                .ForEach(emg => { exercises.Add(emg.Exercise); });
            return exercises;
        }

        private ICollection<Exercise> GetHypertrophyExercisesWithMuscleGroups(HashSet<MuscleGroup> injuredMuscleGroups)
        {
            ICollection<Exercise> exercises = new List<Exercise>();
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise).Where(emg => injuredMuscleGroups.Contains(emg.MuscleGroup) && emg.Exercise.IsHypertrophic == true).ToList()
                .ForEach(emg => { exercises.Add(emg.Exercise); });
            return exercises;
        }

        private ICollection<Exercise> GetUnnecessaryRehabilitationalExercises(HashSet<MuscleGroup> injuredMuscleGroups)
        {
            ICollection<Exercise> exercises = new List<Exercise>();
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise).Where(emg => injuredMuscleGroups.Contains(emg.MuscleGroup) == false && emg.Exercise.IsHypertrophic == false).ToList()
                .ForEach(emg => { exercises.Add(emg.Exercise); });
            return exercises;
        }

        
    }
}
