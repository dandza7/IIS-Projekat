using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.Services
{
    public interface ITrainingSessionService
    {
        public long CreateTrainingSession(TrainingSessionDTO trainingSessionDTO);
        public long AddExerciseToTrainingSession(ExerciseTrainingSessionDTO exerciseTrainingSessionDTO);
    }
}
