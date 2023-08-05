using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;  

namespace IIS_Projekat.Services.Impl
{
    public class TrainingPlanRequestService : ITrainingPlanRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly INotificationService _notificationService;
        private readonly IMedicalRecordService _medicalRecordService;

        public TrainingPlanRequestService(IUnitOfWork unitOfWork, IMapper mapper, INotificationService notificationService, IMedicalRecordService medicalRecordService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _notificationService = notificationService;
            _medicalRecordService = medicalRecordService;
        }

        public PaginationWrapper<PreviewTrainingPlanRequestDTO> GetAllForTrainer(PaginationQuery? paginationQuery, string email)
        {
            var trainer = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            if (trainer == null)
            {
                throw new NotFoundException($"Trainer with given email does not exist!");
            }
            var trainingPlanRequests = _unitOfWork.TrainingPlanRequestRepository.GetAll(tpr => tpr.Client, tpr => tpr.Client.Profile).Where(tpr => tpr.Trainer == trainer).ToList();

            var returnDTOs = _mapper.Map<List<PreviewTrainingPlanRequestDTO>>(trainingPlanRequests);
            returnDTOs.ForEach(req => req.PatientInfo = _medicalRecordService.GetByPatientId(req.ClientId));
            return new PaginationWrapper<PreviewTrainingPlanRequestDTO>(returnDTOs, returnDTOs.Count);
        }

        public long CreateTrainingPlanRequest(TrainingPlanRequestDTO trainingPlanRequestDTO, string email)
        {
            var trainingPlanRequest = _mapper.Map<TrainingPlanRequest>(trainingPlanRequestDTO);
            var client = _unitOfWork.UserRepository.GetAll(c => c.Profile).Where(c => c.Email == email).FirstOrDefault();
            if(client == null)
            {
                throw new NotFoundException($"User with email: {email} does not exists!");
            }
            if(_unitOfWork.TrainingPlanRequestRepository.GetAll().Where(tr => tr.Client == client).FirstOrDefault() != null)
            {
                throw new DuplicateItemException("User has already created a training plan request!");
            }
            var trainer = _unitOfWork.UserRepository.GetAll(t => t.Profile).Where(u => u.Email == trainingPlanRequestDTO.TrainerEmail).FirstOrDefault();
            if (trainer == null)
            {
                throw new NotFoundException($"Trainer with given email: {trainingPlanRequestDTO.TrainerEmail} does not exist!");
            }
            trainingPlanRequest.Trainer = trainer;
            trainingPlanRequest.TrainerId = trainer.Id;
            trainingPlanRequest.Client = client;
            trainingPlanRequest.ClientId = client.Id;
            trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.Create(trainingPlanRequest);

            HandleNotifications(client, trainer);

            _unitOfWork.SaveChanges();
            return trainingPlanRequest.Id;
        }
        public PreviewTrainingPlanRequestDTO GetById(long id)
        {
            var trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.GetById(id, tpr => tpr.Client);
            if(trainingPlanRequest == null)
            {
                throw new NotFoundException($"Training Plan Request with ID: {id} does not exist in the database.");
            }
            var trainingPlanRequestDTO = _mapper.Map<PreviewTrainingPlanRequestDTO>(trainingPlanRequest);
            var client = _unitOfWork.UserRepository.GetById(trainingPlanRequest.ClientId, c => c.Profile);
            trainingPlanRequestDTO.ClientFullName = $"{client.Profile.Name} {client.Profile.Surname}";
            var patientInfo = _medicalRecordService.GetByPatientId(client.Id);
            trainingPlanRequestDTO.PatientInfo = patientInfo;
            return trainingPlanRequestDTO;
        }
        public void DeleteTrainingPlanRequest(long id)
        {
            var trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.GetById(id);
            if (trainingPlanRequest == null)
            {
                throw new NotFoundException($"Training plan request with ID: {id} does not exist!");
            }
            _unitOfWork.TrainingPlanRequestRepository.Delete(trainingPlanRequest);
        }

        private void HandleNotifications(User client, User trainer)
        {
            if (client.Profile == null)
            {
                throw new NotFoundException($"Profile with given email does not exist!");
            }
            var notificationDTO = new NewNotificationDTO
            {
                RecieverEmail = trainer.Email,
                Content = $"You have a new training plan request from {client.Profile.Name} {client.Profile.Surname}!"
            };
            _notificationService.CreateNotification(notificationDTO);
            if (trainer.Profile.IsEmailSubscribed)
            {
                var newEmail = new MailData
                {
                    To = trainer.Email,
                    Subject = "New Training Plan Request",
                    Body = $"Hello {trainer.Profile.Name},\n\n" +
                    $"You have new training plan request from {client.Profile.Name} {client.Profile.Surname}." +
                    $"\n\nRegards,\nIIS Wellness Center."
                };
                _notificationService.SendAsync(newEmail, default);
            }
        }
    }
}
