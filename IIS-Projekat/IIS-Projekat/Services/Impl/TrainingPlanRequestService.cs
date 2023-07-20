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

        public TrainingPlanRequestService(IUnitOfWork unitOfWork, IMapper mapper, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _notificationService = notificationService;
        }

        public PaginationWrapper<PreviewTrainingPlanRequestDTO> GetAll(PaginationQuery? paginationQuery)
        {

            var paginationResult = _unitOfWork.TrainingPlanRequestRepository.Filter(paginationQuery, tpr => tpr.Client, tpr => tpr.Client.Profile);

            return new PaginationWrapper<PreviewTrainingPlanRequestDTO>(_mapper.Map<List<PreviewTrainingPlanRequestDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }
        public long CreateTrainingPlanRequest(TrainingPlanRequestDTO trainingPlanRequestDTO, string email)
        {
            var trainingPlanRequest = _mapper.Map<TrainingPlanRequest>(trainingPlanRequestDTO);
            var client = _unitOfWork.UserRepository.GetAll().Where(c => c.Email == email).FirstOrDefault();
            if(client == null)
            {
                throw new NotFoundException($"User with email: {email} does not exists!");
            }
            if(_unitOfWork.TrainingPlanRequestRepository.GetAll().Where(tr => tr.Client == client).FirstOrDefault() != null)
            {
                throw new DuplicateItemException("User has already created a training plan request!");
            }
            trainingPlanRequest.Client = client;
            trainingPlanRequest.ClientId = client.Id;
            trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.Create(trainingPlanRequest);

            var clientProfile = _unitOfWork.ProfileRepository.GetAll().Where(cp => cp.User == client).FirstOrDefault();
            if(clientProfile == null)
            {
                throw new NotFoundException($"Profile with given email does not exist!");
            }
            var notificationDTO = new NewNotificationDTO
            {
                RecieverEmail = "trener@gmail.com",
                Content = $"You have a new training plan request from {clientProfile.Name} {clientProfile.Surname}!"
            };
            _notificationService.CreateNotification(notificationDTO);

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
            return trainingPlanRequestDTO;
        }
    }
}
