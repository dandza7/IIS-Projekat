﻿using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;
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
            var trainingPlanRequest = _unitOfWork.TrainingPlanRequestRepository.GetById(trainingPlanDTO.TrainingPlanRequestId);
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

        public PaginationWrapper<PreviewTrainingPlanDTO> GetAll()
        {
            var trainingPlans = _unitOfWork.TrainingPlanRepository.GetAll(tp => tp.Client).ToList();
            ICollection<PreviewTrainingPlanDTO> trainingPlanDTOs = new List<PreviewTrainingPlanDTO>();

            foreach(var trainingPlan in trainingPlans)
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
    }
}
