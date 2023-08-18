using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
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

        public PaginationWrapper<PreviewDocumentedSessionDTO> GetSessionForClient(TrainnigSessionPaginationDTO query, string email)
        {
            bool shouldFilter = false;
            if (query.Name != "Any") shouldFilter = true;

            var trainingPlan = GetClientsTrainingPlan(email);
            var retValDTO = new List<PreviewDocumentedSessionDTO>();
            foreach (var session in trainingPlan.TrainingSessions)
            {
                var sessionDTO = new PreviewDocumentedSessionDTO();
                if (shouldFilter && session.Name != query.Name) continue;
                var documentedSets = _unitOfWork.TrainingSetRepository.GetAll()
                    .Where(set => set.TrainingSession == session).ToList();
                if (documentedSets.Count == 0) continue;
                sessionDTO.Date = session.CreatedDate;
                sessionDTO.Name = session.Name;
                foreach (var exerciseDTO in session.ExercisesInSession)
                {
                    var previewExercise = new PreviewDocumentedExerciseDTO();
                    previewExercise.Name = exerciseDTO.Exercise.Name;
                    var previewSet = new List<PreviewTrainingSetDTO>();

                    var setsOfExercise = _unitOfWork.TrainingSetRepository.GetAll()
                        .Where(ts => ts.TrainingSession == session && ts.Exercise == exerciseDTO.Exercise).ToList();
                    
                    foreach(var trainingSet in setsOfExercise)
                    {
                        var setDTO = new PreviewTrainingSetDTO();
                        setDTO.Weight = trainingSet.Weight;
                        setDTO.Repetitions = trainingSet.Repetitions;
                        previewExercise.SetInfo.Add(setDTO);
                    }
                    sessionDTO.ExerciseInfo.Add(previewExercise);
                }
                retValDTO.Add(sessionDTO); 
            }

            return PaginationWrapper<PreviewDocumentedSessionDTO>.WrapItems(_mapper, query.PaginationQuery, retValDTO);
        }

        // Danas je 18.8.2023., ako ovo gledaš u budućnosti srećno jer 
        // jedva i sad znaš kako radi. -N.V.
        public ShouldDocumentNewTrainingSessionDTO ShouldDocumentNewSession(string email)
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
            if(retVal.isTodayDocumented || retVal.isMaxSessionsReached)
            {
                retVal.NewTrainingSessionInfo = newTrainingSessionDTO;
                return retVal;
            }

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

        public void DocumentNewTrainingSession(string email, NewDocumentedTrainingSessionDTO session)
        {
            var trainingPlan = GetClientsTrainingPlan(email);
            TrainingSession enteredSession = CheckIfTrainingSessionExistsInPlan(trainingPlan, session.Name);

            foreach (var exerciseDTO in session.ExerciseInfo)
            {
                var exercise = _unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == exerciseDTO.Name).FirstOrDefault();
                if(exercise == null)
                {
                    throw new NotFoundException($"Exercise with name {exerciseDTO.Name} does not exist in the database.");
                }
                foreach (var setDTO in exerciseDTO.SetInfo)
                {
                    var trainingSet = MapTrainingSet(enteredSession, exercise, setDTO);
                    _unitOfWork.TrainingSetRepository.Create(trainingSet);
                }
            }
            _unitOfWork.SaveChanges();
        }

        private TrainingSet MapTrainingSet(TrainingSession enteredSession, Exercise exercise, NewTrainingSetDTO setDTO)
        {
            var trainingSet = new TrainingSet();
            trainingSet.TrainingSession = enteredSession;
            trainingSet.TrainingSessionId = enteredSession.Id;
            trainingSet.Exercise = exercise;
            trainingSet.ExerciseId = exercise.Id;
            trainingSet.Repetitions = setDTO.Repetitions;
            trainingSet.Weight = setDTO.Weight;
            return trainingSet;
        }

        private TrainingSession CheckIfTrainingSessionExistsInPlan(TrainingPlan trainingPlan, string sessionName)
        {
            foreach (var trainingSession in trainingPlan.TrainingSessions)
                if (trainingSession.Name == sessionName) return trainingSession;

            throw new NotFoundException($"Session with name {sessionName} does not exist in client's plan.");
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
