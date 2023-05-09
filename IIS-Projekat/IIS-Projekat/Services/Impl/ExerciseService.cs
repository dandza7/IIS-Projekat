using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class ExerciseService : IExerciseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExerciseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public long CreateExercise(NewExerciseDTO newExerciseDTO)
        {
            Exercise newExercise = new Exercise();
            newExercise.Name = newExerciseDTO.Name;
            newExercise.IsHypertrophic = (newExerciseDTO.IsHypertrophic) ? true : false;
            AddPrimaryMuscleGroup(newExercise, newExerciseDTO.PrimaryMuscleGroup);
            AddSecondaryMuscleGroups(newExercise, newExerciseDTO.SecondaryMuscleGroups);
            newExercise = _unitOfWork.ExerciseRepository.Create(newExercise);
            _unitOfWork.SaveChanges();
            return newExercise.Id;
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
