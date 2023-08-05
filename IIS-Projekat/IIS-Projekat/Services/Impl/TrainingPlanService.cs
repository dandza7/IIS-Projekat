using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Plan;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class TrainingPlanService: ITrainingPlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly INotificationService _notificationService;
        public TrainingPlanService(IUnitOfWork unitOfWork, IMapper mapper, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _notificationService = notificationService;
        }

        public long CreateTrainingPlan(TrainingPlanDTO trainingPlanDTO)
        {
            var trainingPlan = CreateTrainingPlanBase(trainingPlanDTO);
            AddTrainingSessionsToPlan(trainingPlan, trainingPlanDTO);

            var clientProfile = _unitOfWork.ProfileRepository.GetAll().Where(cp => cp.User == trainingPlan.Client).FirstOrDefault();
            if (clientProfile == null)
            {
                throw new NotFoundException($"Profile with given email does not exist!");
            }
            var notificationDTO = new NewNotificationDTO
            {
                RecieverEmail = trainingPlan.Client.Email,
                Content = $"Your training plan is complete!"
            };

            _notificationService.CreateNotification(notificationDTO);
            _unitOfWork.SaveChanges();
            return trainingPlan.Id;
        }
        public PaginationWrapper<PreviewTrainingPlanDTO> GetAll(PaginationQuery paginationQuery)
        {
            var trainingPlans = _unitOfWork.TrainingPlanRepository.Filter(paginationQuery, tp => tp.Client);
            ICollection<PreviewTrainingPlanDTO> trainingPlanDTOs = new List<PreviewTrainingPlanDTO>();

            foreach(var trainingPlan in trainingPlans.Items)
            {
                PreviewTrainingPlanDTO currentPlan = _mapper.Map<PreviewTrainingPlanDTO>(trainingPlan);
                var client = _unitOfWork.UserRepository.GetById(trainingPlan.ClientId, c => c.Profile);

                if (client.Profile.Name == null || client.Profile.Surname == null)
                {
                    currentPlan.ClientName = $"Client did not set up his profile.";
                }
                else
                {
                    currentPlan.ClientName = $"{client.Profile.Name} {client.Profile.Surname}";
                }
                trainingPlanDTOs.Add(currentPlan);
            }

            return new PaginationWrapper<PreviewTrainingPlanDTO>(trainingPlanDTOs.ToList(), trainingPlanDTOs.Count);
        }
        public PreviewDetailedTrainingPlanDTO GetDetailedTrainingPlanForTrainer(long id)
        {
            var trainingPlan = _unitOfWork.TrainingPlanRepository.GetById(id, tp => tp.Client);

            if(trainingPlan == null)
            {
                throw new NotFoundException($"Training Plan with ID: {id} does not exist in the database.");
            }

            PreviewDetailedTrainingPlanDTO detailedTrainingPlan = _mapper.Map<PreviewDetailedTrainingPlanDTO>(trainingPlan);
            var client = _unitOfWork.UserRepository.GetById(trainingPlan.ClientId, c => c.Profile);
            if (client == null)
            {
                throw new NotFoundException($"Client for training plan with ID: {id} does not exist in the database.");
            }

            if (client.Profile.Name == null || client.Profile.Surname == null)
            {
                detailedTrainingPlan.ClientName = $"Client did not set up his profile.";
            } else
            {
                detailedTrainingPlan.ClientName = $"{client.Profile.Name} {client.Profile.Surname}";
            }
            
            ICollection<TrainingSession> trainingSessions = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.TrainingPlan == trainingPlan).ToList();
            foreach(var trainnigSession in trainingSessions)
            {
                PreviewTrainingSessionDTO currentSession = _mapper.Map<PreviewTrainingSessionDTO>(trainnigSession);
                ICollection<ExerciseTrainingSession> exercisesInCurrentSession = _unitOfWork.ExerciseTrainingSessionRepository
                    .GetAll(ets => ets.Exercise).Where(ets => ets.TrainingSession == trainnigSession).ToList();
                foreach(var exerciseTS in  exercisesInCurrentSession)
                {
                    PreviewExerciseTrainingSessionDTO currentExerciseTS = _mapper.Map<PreviewExerciseTrainingSessionDTO>(exerciseTS);
                    currentSession.ExerciseInfo.Add(currentExerciseTS);
                }
                detailedTrainingPlan.TrainingSessions.Add(currentSession);
            }

            return detailedTrainingPlan;
        }
        public PreviewTrainingPlanForClient GetTrainingPlanForClient(string email)
        {
            var client = _unitOfWork.UserRepository.GetAll().ToList().Where(c => c.Email == email).FirstOrDefault();
            if(client == null)
            {
                throw new NotFoundException("Client does not exist in the database.");
            }
            var trainingPlan = _unitOfWork.TrainingPlanRepository.GetAll().ToList().Where(tp => tp.Client == client).FirstOrDefault();
            if(trainingPlan == null)
            {
                throw new NotFoundException("Client does not have a training plan.");
            }
            var trainingPlanDTO = _mapper.Map<PreviewTrainingPlanForClient>(trainingPlan);

            ICollection<TrainingSession> trainingSessions = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.TrainingPlan == trainingPlan).ToList();

            foreach(var trainingSession in trainingSessions)
            {
                var trainingSessionDTO = _mapper.Map<PreviewTrainingSessionDTO>(trainingSession);
                var exercisesInSession = _unitOfWork.ExerciseTrainingSessionRepository.GetAll(ets => ets.Exercise).Where(ets => ets.TrainingSession == trainingSession).ToList();
                foreach(var exercise in exercisesInSession)
                {
                    var exerciseDTO = _mapper.Map<PreviewExerciseTrainingSessionDTO>(exercise);
                    trainingSessionDTO.ExerciseInfo.Add(exerciseDTO);
                }
                trainingPlanDTO.TrainingSessions.Add(trainingSessionDTO);
            }

            return trainingPlanDTO;
        }
        private TrainingPlan CreateTrainingPlanBase(TrainingPlanDTO trainingPlanDTO)
        {
            var trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.GetById(trainingPlanDTO.TrainingPlanRequestId);
            if (trainingPlanRequest == null)
            {
                throw new BadHttpRequestException($"Training plan was not requested!");
            }
            var trainingPlan = _mapper.Map<TrainingPlan>(trainingPlanDTO);
            var trainer = _unitOfWork.UserRepository.GetById(trainingPlanRequest.TrainerId);
            if (trainer == null)
            {
                throw new NotFoundException($"Trainer was not found in the database!");
            }
            trainingPlan.Trainer = trainer;
            trainingPlan.TrainerId = trainer.Id;

            var client = _unitOfWork.UserRepository.GetAll().Where(c => c.Id == trainingPlanRequest.ClientId).FirstOrDefault();
            if (client == null)
            {
                throw new NotFoundException($"Client with ID: {trainingPlanRequest.ClientId} does not exist!");
            }
            trainingPlan.Client = client;
            trainingPlan.ClientId = client.Id;

            trainingPlan = _unitOfWork.TrainingPlanRepository.Create(trainingPlan);
            _unitOfWork.TrainingPlanRequestRepository.Delete(trainingPlanRequest);
            return trainingPlan;
        }
        private void AddTrainingSessionsToPlan(TrainingPlan trainingPlan, TrainingPlanDTO trainingPlanDTO)
        {
            foreach (var trainingSessionDTO in trainingPlanDTO.TrainingSessions)
            {
                CheckIfTrainingSessionNameIsUnique(trainingPlan, trainingSessionDTO);
                var trainingSession = _mapper.Map<TrainingSession>(trainingSessionDTO);
                trainingSession.TrainingPlan = trainingPlan;
                trainingSession = _unitOfWork.TrainingSessionRepository.Create(trainingSession);
                AddExercisesToTrainingSession(trainingSession, trainingSessionDTO);
            }
        }
        private void CheckIfTrainingSessionNameIsUnique(TrainingPlan trainingPlan, TrainingSessionWithPlanDTO trainingSessionDTO)
        {
            ICollection<TrainingSession> existingSessions = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.TrainingPlan == trainingPlan).ToList();
            foreach (var existingSession in existingSessions)
            {
                if (existingSession.Name == trainingSessionDTO.Name)
                {
                    throw new BadHttpRequestException("Training Session names in a single Training Plan must be unique.");
                }
            }
        }
        private void AddExercisesToTrainingSession(TrainingSession trainingSession, TrainingSessionWithPlanDTO trainingSessionDTO)
        {
            foreach (var exerciseDTO in trainingSessionDTO.Exercises)
            {
                ExerciseTrainingSession exerciseForSession = _mapper.Map<ExerciseTrainingSession>(exerciseDTO);
                var exercise = _unitOfWork.ExerciseRepository.GetById(exerciseDTO.ExerciseId);
                if (exercise == null)
                {
                    throw new NotFoundException($"Exercise with ID: {exerciseDTO.ExerciseId} does not exist in the database");
                }
                exerciseForSession.TrainingSession = trainingSession;
                exerciseForSession.Exercise = exercise;
                _unitOfWork.ExerciseTrainingSessionRepository.Create(exerciseForSession);
            }
        }
    }
}
