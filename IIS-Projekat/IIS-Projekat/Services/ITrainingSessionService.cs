using IIS_Projekat.Models.DTOs.Training;

namespace IIS_Projekat.Services
{
    public interface ITrainingSessionService
    {
        public long CreateTrainingSession(TrainingSessionDTO trainingSessionDTO);
        public long AddExerciseToTrainingSession(ExerciseTrainingSessionDTO exerciseTrainingSessionDTO);
    }
}
