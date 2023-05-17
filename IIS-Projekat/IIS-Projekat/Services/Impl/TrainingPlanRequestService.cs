using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class TrainingPlanRequestService : ITrainingPlanRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingPlanRequestService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
            _unitOfWork.SaveChanges();
            return trainingPlanRequest.Id;
        }
    }
}
