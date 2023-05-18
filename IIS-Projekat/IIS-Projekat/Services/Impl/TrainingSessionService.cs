using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class TrainingSessionService: ITrainingSessionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingSessionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long UpdateTrainingSession(UpdateTrainingSessionDTO trainingSessionDTO)
        {
            var trainingSession = _unitOfWork.TrainingSessionRepository.GetAll(ts => ts.TrainingPlan).Where(ts => ts.TrainingPlan.Id == trainingSessionDTO.TrainingPlanId && ts.Name == trainingSessionDTO.OldSessionName).FirstOrDefault();
            if (trainingSession == null) 
            {
                throw new NotFoundException($"Training Session with name: {trainingSessionDTO.OldSessionName} does not exist in the Training Plan.");
            }
            trainingSession.Name = trainingSessionDTO.NewSessionName;

            var exercisesInTrainingSession = _unitOfWork.ExerciseTrainingSessionRepository.GetAll().Where(ets => ets.TrainingSession == trainingSession).ToList();
            foreach(var exercise in exercisesInTrainingSession)
            {
                _unitOfWork.ExerciseTrainingSessionRepository.Delete(exercise); 
            }
            foreach(var newExerciseTS in trainingSessionDTO.Exercises)
            {
                var newExercise = _unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == newExerciseTS.ExerciseName).FirstOrDefault();
                if(newExercise == null)
                {
                    throw new NotFoundException($"Exercise with name: {newExerciseTS.ExerciseName} does not exist.");
                }
                ExerciseTrainingSession newExerciseInSession = _mapper.Map<ExerciseTrainingSession>(newExerciseTS);
                newExerciseInSession.Exercise = newExercise;
                newExerciseInSession.TrainingSession = trainingSession;
                newExerciseInSession = _unitOfWork.ExerciseTrainingSessionRepository.Create(newExerciseInSession);
            }
            _unitOfWork.SaveChanges();
            return trainingSession.Id;
        }
    }
}
