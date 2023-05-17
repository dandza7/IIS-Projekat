using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class TrainingPlanService: ITrainingPlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingPlanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long CreateTrainingPlan(TrainingPlanDTO trainingPlanDTO)
        {
            var trainingPlan = _mapper.Map<TrainingPlan>(trainingPlanDTO);
            var trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.GetAll().Where(tpr => tpr.Id == trainingPlanDTO.TrainingPlanRequestId).FirstOrDefault();
            if (trainingPlanRequest == null)
            {
                throw new BadHttpRequestException($"Training plan was not requested!");
            }

            var client = _unitOfWork.UserRepository.GetAll().Where(c => c.Id == trainingPlanRequest.ClientId).FirstOrDefault();
            if (client == null)
            {
                throw new NotFoundException($"Client with ID: {trainingPlanRequest.ClientId} does not exist!");
            }

            trainingPlan.Client = client;
            trainingPlan.ClientId = client.Id;

            _unitOfWork.TrainingPlanRequestRepository.Delete(trainingPlanRequest);
            trainingPlan = _unitOfWork.TrainingPlanRepository.Create(trainingPlan);
            _unitOfWork.SaveChanges();
            return trainingPlan.Id;
        }
    }
}
