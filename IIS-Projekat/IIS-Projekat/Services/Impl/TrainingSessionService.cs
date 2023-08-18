using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Exercise;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Models.DTOs.Training.Set;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.Exercise_Properties;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

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

        public ShouldDocumentNewTrainingSessionDTO ShouldDocumentNewSessionDTO(string email)
        {
            var trainingPlan = GetClientsTrainingPlan(email);
            // -1 jer je ponedeljak 1 a ne 0
            var todaysDay = ((int)DateTime.Now.DayOfWeek) - 1;
            var lastDocumentedSession = DateTime.Now.AddDays(-10);
            var documentedSessionsThisWeek = 0;
            TrainingSession? lastTrainingSession = null;
            int lastSessionIndex = -1;
            
            int sessionIndex = 0;
            foreach(var trainingSession in  trainingPlan.TrainingSessions)
            {
                // dobavi sve dokumentovane setove za sesije iz ove sedmice
                var documentedSets = _unitOfWork.TrainingSetRepository.GetAll()
                    .Where(set => set.TrainingSession == trainingSession && set.CreatedDate >= DateTime.Now.AddDays(-todaysDay))
                    .ToList();
                // odradio je taj trening ove sedmice
                if (documentedSets.Count > 0)
                {
                    // uvecaj broj sesija ove sedmice
                    ++documentedSessionsThisWeek;
                    // provjeri da li je sesija bila kasnije u odnosu na prošlu najkasniju
                    if (documentedSets[0].CreatedDate > lastDocumentedSession)
                    {
                        lastDocumentedSession = documentedSets[0].CreatedDate;
                        lastTrainingSession = trainingSession;
                        lastSessionIndex = sessionIndex;
                    }
                }
                sessionIndex++;
            }

            ShouldDocumentNewTrainingSessionDTO retVal = new ShouldDocumentNewTrainingSessionDTO();
            retVal.isTodayDocumented = CompareTodayWithLastDocumented(lastDocumentedSession);
            retVal.isMaxSessionsReached = documentedSessionsThisWeek == trainingPlan.SessionsPerWeek;

            var newTrainingSessionDTO = new PreviewNewTrainingSessionDTO();
            var newSessionIndex = (lastSessionIndex == (trainingPlan.TrainingSessions.Count - 1)) ? 0 : lastSessionIndex + 1;
            newTrainingSessionDTO.Name = trainingPlan.TrainingSessions.ToList()[newSessionIndex].Name;
            foreach(var exerciseInfo in trainingPlan.TrainingSessions.ToList()[newSessionIndex].ExercisesInSession)
            {
                List<PreviewNewTrainingSetDTO> setInfo = new();
                for (int i = 0; i < exerciseInfo.NumberOfSets; i++) 
                    setInfo.Add(new PreviewNewTrainingSetDTO
                    {
                        Weight = 0,
                        Repetitions = 0
                    });
               
                newTrainingSessionDTO.ExerciseInfo.Add(
                        new PreviewNewExerciseDTO
                        {
                            Name = exerciseInfo.Exercise.Name,
                            SetInfo = setInfo
                        }
                    );
            }
            retVal.NewTrainingSessionInfo = newTrainingSessionDTO;
            return retVal;
        }

        private bool CompareTodayWithLastDocumented(DateTime lastDocumentedSession)
        {
            if (lastDocumentedSession.Date.Year != DateTime.Now.Date.Year) return false;
            if (lastDocumentedSession.Date.Month != DateTime.Now.Date.Month) return false;
            if (lastDocumentedSession.Date.Day != DateTime.Now.Date.Day) return false;
            return true;
        }

        private TrainingPlan GetClientsTrainingPlan(string email)
        {
            var client = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault();
            if (client == null)
            {
                throw new NotFoundException($"User with email: {email} does not exist in the database");
            }
            var trainingPlan = _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.ClientId == client.Id)
                .Include(tp => tp.TrainingSessions)
                .ThenInclude(ts => ts.ExercisesInSession)
                .ThenInclude(ets => ets.Exercise)
                .FirstOrDefault();
            if (trainingPlan == null)
            {
                throw new NotFoundException($"User with email: {email} does not have a training plan.");
            }
            return trainingPlan;
        }
    }
}
