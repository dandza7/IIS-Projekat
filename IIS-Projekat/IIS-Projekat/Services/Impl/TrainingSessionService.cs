using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
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

        public long CreateTrainingSession(TrainingSessionDTO trainingSessionDTO)
        {
            var trainingSession = _mapper.Map<TrainingSession>(trainingSessionDTO);
            var trainingPlan = _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.Id == trainingSessionDTO.TrainingPlanId).FirstOrDefault();
            if(trainingPlan == null)
            {
                throw new NotFoundException($"Training plan with ID: {trainingSessionDTO.TrainingPlanId} does not exist.");
            }
            var currentSessionsPerWeek = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.TrainingPlan == trainingPlan).Count();
            if(trainingPlan.SessionsPerWeek == currentSessionsPerWeek)
            {
                throw new BadHttpRequestException($"Training plan already has maximum number of sessions requested by client.");
            }

            trainingSession.TrainingPlan = trainingPlan;
            trainingSession = _unitOfWork.TrainingSessionRepository.Create(trainingSession);

            if(trainingSessionDTO.ExerciseInfo != null)
            {
                trainingSessionDTO.ExerciseInfo.ToList().ForEach(exerciseInfo => {
                    AddExerciseToTrainingSession(exerciseInfo);
                });
            }
            
            _unitOfWork.SaveChanges();
            return trainingSession.Id;
        }

        public long AddExerciseToTrainingSession(ExerciseTrainingSessionDTO exerciseTrainingSessionDTO)
        {
            var exercise = _unitOfWork.ExerciseRepository.GetAll().Where(e => e.Id == exerciseTrainingSessionDTO.ExerciseId).FirstOrDefault();
            if (exercise == null)
            {
                throw new NotFoundException($"Exercise with ID: {exerciseTrainingSessionDTO.ExerciseId} does not exist.");
            }
            var trainingSession = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.Id == exerciseTrainingSessionDTO.TrainingSessionId).FirstOrDefault();
            if (trainingSession == null)
            {
                throw new NotFoundException($"Training Session with ID: {exerciseTrainingSessionDTO.TrainingSessionId} does not exist.");
            }
            if (!RepetitionRange.IsRepetitionRangeValid(exerciseTrainingSessionDTO.RepetitionRange))
            {
                throw new BadHttpRequestException($"Repetition range is not valid.");
            }
            if (exerciseTrainingSessionDTO.NumberOfSets < 1 || exerciseTrainingSessionDTO.NumberOfSets > 8)
            {
                throw new BadHttpRequestException($"Number of sets per exercise must be between 1 and 8");
            }

            ExerciseTrainingSession exerciseTrainingSession = new ExerciseTrainingSession();
            exerciseTrainingSession.Exercise = exercise;
            exerciseTrainingSession.TrainingSession = trainingSession;
            exerciseTrainingSession.RepetitionRange = exerciseTrainingSessionDTO.RepetitionRange;
            exerciseTrainingSession.NumberOfSets = exerciseTrainingSessionDTO.NumberOfSets;
            exerciseTrainingSession = _unitOfWork.ExerciseTrainingSessionRepository.Create(exerciseTrainingSession);
            _unitOfWork.SaveChanges();
            return exerciseTrainingSession.Id;
        }
    }
}
