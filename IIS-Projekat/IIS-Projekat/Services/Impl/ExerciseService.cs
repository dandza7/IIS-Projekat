﻿using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using Microsoft.EntityFrameworkCore;
using IIS_Projekat.SupportClasses.Roles;
using System.Linq;

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

        public PaginationWrapper<PreviewExerciseDTO> GetSuitableExercisesForClient(long clientId, ExerciseFilterDTO exerciseFilterDTO)
        {
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == clientId).FirstOrDefault();
            if(medicalRecord == null)
            {
                throw new NotFoundException($"Client with ID: {clientId} does not have a medical record.");
            }
            HashSet<MuscleGroup> lowSeverityInjuries = DiagnoseInjuriesWithGivenSeverity("Low", medicalRecord);
            HashSet<MuscleGroup> highSeverityInjuries = DiagnoseInjuriesWithGivenSeverity("High", medicalRecord);
            ICollection<Exercise> suitableExercises = _unitOfWork.ExerciseRepository
                .GetAll().Include(e => e.MuscleGroups).ThenInclude(mg => mg.MuscleGroup).ToHashSet();

            ApplyExerciseFilters(suitableExercises, exerciseFilterDTO);
            RemoveExercisesWithInjuredPrimaryMuscleGroups(suitableExercises, lowSeverityInjuries);
            RemoveExercisesWithInjuredMuscleGroups(suitableExercises, highSeverityInjuries);
            RemoveUnnecessaryRehabilitationExercises(suitableExercises, medicalRecord);

            return new PaginationWrapper<PreviewExerciseDTO>(_mapper.Map<List<PreviewExerciseDTO>>(suitableExercises), suitableExercises.Count);
        }

        public PaginationWrapper<PreviewExerciseDTO> GetAll(PaginationQuery? paginationQuery)
        {
            var exercises = _unitOfWork.ExerciseRepository.GetAll().Include(e => e.MuscleGroups).ThenInclude(mg => mg.MuscleGroup).ToList();
            return new PaginationWrapper<PreviewExerciseDTO>(_mapper.Map<List<PreviewExerciseDTO>>(exercises), exercises.Count);
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

        private HashSet<MuscleGroup> DiagnoseInjuriesWithGivenSeverity(string severity, MedicalRecord medicalRecord)
        {
            ICollection<InjuredMuscleTherapy> clientInjuries = _unitOfWork.InjuredMuscleTherapyRepository.GetAll(imt => imt.InjuredMuscle).Include(it => it.Therapy).ThenInclude(t => t.MedicalRecord).Where(it => it.Therapy.MedicalRecord == medicalRecord).ToList();
            HashSet<MuscleGroup> injuredMuscleGroups = new HashSet<MuscleGroup>();

            foreach(var injury in clientInjuries) { 
                var injuredMuscle = _unitOfWork.MuscleGroupRepository.GetById(injury.InjuredMuscle.Id);
                if (injury.InjurySeverity == severity) injuredMuscleGroups.Add(injuredMuscle);
            }

            return injuredMuscleGroups;
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

        private void RemoveExercisesWithInjuredPrimaryMuscleGroups(ICollection<Exercise> exercises, HashSet<MuscleGroup> injuredMuscleGroups)
        {
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise).Where(emg => injuredMuscleGroups
                .Contains(emg.MuscleGroup) && emg.IsPrimaryMuscleGroup == true && emg.Exercise.IsHypertrophic == true).ToList()
                .ForEach(emg => exercises.Remove(emg.Exercise));
        }

        private void RemoveExercisesWithInjuredMuscleGroups(ICollection<Exercise> exercises, HashSet<MuscleGroup> injuredMuscleGroups)
        {
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise).Where(emg => injuredMuscleGroups
                .Contains(emg.MuscleGroup) && emg.Exercise.IsHypertrophic == true).ToList()
                .ForEach(emg => exercises.Remove(emg.Exercise));
        }

        private void RemoveUnnecessaryRehabilitationExercises(ICollection<Exercise> exercises, MedicalRecord medicalRecord)
        {
            _unitOfWork.TherapyRepository.GetAll(t => t.MedicalRecord, t => t.RecommendedExercises, t => t.RecommendedExercises)
                .Where(t => t.MedicalRecord == medicalRecord).ToList().ForEach(t =>
                {
                    foreach(var exercise in t.RecommendedExercises)
                    {
                        exercises.Remove(exercise);
                    }
                });
        }

        private void FilterOutRehablitationExercises(ICollection<Exercise> exercises)
        {
            _unitOfWork.ExerciseRepository.GetAll().Where(e => e.IsHypertrophic == false).ToList()
                .ForEach(e =>
                {
                    exercises.Remove(e);
                });
        }

        private void FilterOutHypertrophyExercises(ICollection<Exercise> exercises)
        {
            _unitOfWork.ExerciseRepository.GetAll().Where(e => e.IsHypertrophic == true).ToList()
                .ForEach(e =>
                {
                    exercises.Remove(e);
                });
        }

        private void GetOnlyExercisesWithGivenPrimaryGroup(ICollection<Exercise> exercises, string primaryMuscleGroup)
        {
            var muscle = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == primaryMuscleGroup).FirstOrDefault();
            if(muscle == null)
            {
                throw new NotFoundException($"Muscle group with the name: {primaryMuscleGroup} does not exist!");
            }
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise, emg => emg.MuscleGroup)
                .Where(emg => emg.MuscleGroup != muscle && emg.IsPrimaryMuscleGroup == true).ToList()
                .ForEach(emg => exercises.Remove(emg.Exercise));
        }

        private void GetOnlyExercisesWithGivenSecondaryGroup(ICollection<Exercise> exercises, string secondaryMuscleGroup)
        {
            var muscle = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == secondaryMuscleGroup).FirstOrDefault();
            if (muscle == null)
            {
                throw new NotFoundException($"Muscle group with the name: {secondaryMuscleGroup} does not exist!");
            }
            List<Exercise> exercisesWhichWorkMuscleSecondarily = new List<Exercise>();
            _unitOfWork.ExerciseMuscleGroupRepository.GetAll(emg => emg.Exercise, emg => emg.MuscleGroup)
                .Where(emg => emg.MuscleGroup == muscle && emg.IsPrimaryMuscleGroup == false && emg.Exercise.IsHypertrophic == true)
                .ToList().ForEach(emg => { exercisesWhichWorkMuscleSecondarily.Add(emg.Exercise); });
            
            foreach(var exercise in exercises)
            {
                if (!exercisesWhichWorkMuscleSecondarily.Contains(exercise)) exercises.Remove(exercise);
            }
        }

        private void ApplyExerciseFilters(ICollection<Exercise> exercises, ExerciseFilterDTO exerciseFilterDTO)
        {
            if(exerciseFilterDTO.ExerciseNature == "Rehabilitation")
            {
                FilterOutHypertrophyExercises(exercises);
                return;
            }

            if(exerciseFilterDTO.ExerciseNature == "Hypertrophic")
            {
                FilterOutRehablitationExercises(exercises);
            }

            if(_unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == exerciseFilterDTO.PrimaryMuscleGroup).FirstOrDefault() != null)
            {
                GetOnlyExercisesWithGivenPrimaryGroup(exercises, exerciseFilterDTO.PrimaryMuscleGroup);
            }else if (_unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == exerciseFilterDTO.SecondarymuscleGroup).FirstOrDefault() != null)
            {
                GetOnlyExercisesWithGivenSecondaryGroup(exercises, exerciseFilterDTO.SecondarymuscleGroup);
            }
        }
    }
}
