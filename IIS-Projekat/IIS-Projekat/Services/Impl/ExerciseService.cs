using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;

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

        public long CreateExercise(NewExerciseDTO newExerciseDTO)
        {
            Exercise newExercise = new Exercise();
            if(_unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == newExerciseDTO.Name).FirstOrDefault() != null)
            {
                throw new ArgumentException("Exercise with given name already exists in the database!");
            }
            newExercise.Name = newExerciseDTO.Name;
            newExercise.IsHypertrophic = (newExerciseDTO.IsHypertrophic) ? true : false;
            AddPrimaryMuscleGroup(newExercise, newExerciseDTO.PrimaryMuscleGroup);
            AddSecondaryMuscleGroups(newExercise, newExerciseDTO.SecondaryMuscleGroups);
            newExercise = _unitOfWork.ExerciseRepository.Create(newExercise);
            _unitOfWork.SaveChanges();
            return newExercise.Id;
        }

        public PaginationWrapper<ExerciseDTO> GetAll(PaginationQuery? paginationQuery)
        {

            var paginationResult = _unitOfWork.ExerciseRepository.Filter(paginationQuery);
            return new PaginationWrapper<ExerciseDTO>(_mapper.Map<List<ExerciseDTO>>(paginationResult.Items), paginationResult.TotalCount);
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
    }
}
