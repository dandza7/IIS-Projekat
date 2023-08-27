using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.Repositories;
using IIS_Projekat.Models.DTOs.Training;

namespace IIS_Projekat.Services.Impl
{
    public class MeasurementService: IMeasurementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MeasurementService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long CreateMeasurement(NewMeasurementDTO measurementDTO, string email)
        {
            var patient = _unitOfWork.UserRepository.GetAll().Where(p => p.Email == email).FirstOrDefault();
            if (patient == null)
            {
                throw new NotFoundException($"Patient with given email does not exist!");
            }
            var medicalRecord = _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == patient.Id).FirstOrDefault();
            if (medicalRecord == null)
            {
                throw new NotFoundException("Patient does not have medical record!");
            }
            var measurement = _mapper.Map<Measurement>(measurementDTO);
            measurement.MedicalRecord = medicalRecord;
            measurement.MedicalRecordId = medicalRecord.Id;
            measurement = _unitOfWork.MeasurementRepository.Create(measurement);
            _unitOfWork.SaveChanges();
            return measurement.Id;
        }

        public PreviewStatisticsDTO GetStatisticsForPatient(long id, string email, StatisticsFilterDTO query) 
        {
            var patient = (id == -1) ? _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).FirstOrDefault() :
                _unitOfWork.UserRepository.GetById(id);

            if (patient == null)
            {
                throw new NotFoundException("Customer does not exist in the database.");
            }

            bool wantsAnythingFromMedRecord = query.WantsWeight || query.WantsBicep || query.WantsForearm ||
                query.WantsChest || query.WantsWaist || query.WantsThigh || query.WantsCalf;
            var medicalRecord = (wantsAnythingFromMedRecord) ? _unitOfWork.MedicalRecordRepository.GetAll().Where(mr => mr.PatientId == patient.Id).FirstOrDefault() : null;
            if (medicalRecord == null && wantsAnythingFromMedRecord)
            {
                throw new NotFoundException("Customer does not have a medical record.");
            }

            var trainingPlan = (query.ExerciseName != "False") ? _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.ClientId == patient.Id).FirstOrDefault() : null;
            if (trainingPlan == null && query.ExerciseName != "False") 
            {
                throw new NotFoundException("Customer does not have a training plan.");
            } 

            ICollection<Measurement> measurements = new List<Measurement>();
            ICollection<TrainingSet> trainingSets = new List<TrainingSet>();

            switch (query.TimePeriod) {
                case "Month":
                    if (wantsAnythingFromMedRecord) measurements = GetWeightsForTimePeriod(medicalRecord, 30);
                    if(query.ExerciseName != "False")
                    {
                        trainingSets = GetExericseStatisticsForTimePeriod(trainingPlan, 30, query.ExerciseName);
                        trainingSets = GetBestSetsForTimePeriod(trainingSets.ToList());
                    }
                    break;
                case "Year":
                    if (wantsAnythingFromMedRecord) measurements = GetWeightsForTimePeriod(medicalRecord, 365);
                    if (query.ExerciseName != "False")
                    {
                        trainingSets = GetExericseStatisticsForTimePeriod(trainingPlan, 365, query.ExerciseName);
                        trainingSets = GetBestSetsForTimePeriod(trainingSets.ToList());
                    }
                    break;
                default:
                    if (wantsAnythingFromMedRecord) measurements = GetWeightsForTimePeriod(medicalRecord, 3650);
                    if (query.ExerciseName != "False")
                    {
                        trainingSets = GetExericseStatisticsForTimePeriod(trainingPlan, 3650, query.ExerciseName);
                        trainingSets = GetBestSetsForTimePeriod(trainingSets.ToList());
                    }
                    break;
            }
            return MapStatisticsToPreview(query, measurements.ToList(), trainingSets.ToList());
        }

        private List<Measurement> GetWeightsForTimePeriod(MedicalRecord medicalRecord, int pastDays)
        {
            return _unitOfWork.MeasurementRepository.GetAll().
                Where(m => m.MedicalRecordId == medicalRecord.Id && 
                m.CreatedDate >= DateTime.UtcNow.AddDays(-pastDays)).ToList();
        }

        private List<TrainingSet> GetExericseStatisticsForTimePeriod(TrainingPlan trainingPlan, int pastDays, string exerciseName)
        {
            List<TrainingSet> trainingSets = new List<TrainingSet>();
            var sessions = _unitOfWork.TrainingSessionRepository.GetAll().Where(ts => ts.TrainingPlan == trainingPlan).ToList();
            foreach (var session in sessions)
            {
                var exercises = _unitOfWork.ExerciseTrainingSessionRepository.GetAll(ets => ets.Exercise).Where(ets => ets.TrainingSession == session).ToList();
                foreach (var exercise in exercises)
                {
                    _unitOfWork.TrainingSetRepository.GetAll()
                        .Where(e => e.TrainingSession == session && e.Exercise == exercise.Exercise &&
                        e.CreatedDate >= DateTime.UtcNow.AddDays(-pastDays) &&
                        exerciseName == exercise.Exercise.Name)
                        .OrderBy(e => e.CreatedDate).ToList().ForEach(e => trainingSets.Add(e));
                }
            }
            if (trainingSets.Count == 0)
            {
                throw new NotFoundException($"Customer did not have {exerciseName} prescribed.");
            }
            return trainingSets;
        }

        private List<TrainingSet> GetBestSetsForTimePeriod(List<TrainingSet> trainingSets)
        {
            List<TrainingSet> bestSets = new List<TrainingSet>();
            var currentMax = trainingSets[0].Weight;
            var currentSet = trainingSets[0];

            foreach(var set in trainingSets)
            {
                if(!IsSameSession(currentSet.CreatedDate, set.CreatedDate))
                {
                    bestSets.Add(currentSet);
                    currentMax = -1;
                } 

                
                if (currentMax < set.Weight)
                {
                    currentMax = set.Weight;
                    currentSet = set;
                }
            }

            return bestSets;
        }

        private bool IsSameSession(DateTime currentSession, DateTime potentialNext)
        {
            if (currentSession.Year != potentialNext.Year) return false;
            if (currentSession.Month != potentialNext.Month) return false;
            if (currentSession.Day != potentialNext.Day) return false;
            return true;
        }

        private PreviewStatisticsDTO MapStatisticsToPreview(StatisticsFilterDTO query, List<Measurement> measurements, List<TrainingSet> sets)
        {
            var summary = new PreviewStatisticsDTO();

            summary.WeightStatistics = new List<StatisticsDTO>();
            summary.BicepStatistics = new List<StatisticsDTO>(); 
            summary.ForearmStatistics = new List<StatisticsDTO>();
            summary.ChestStatistics = new List<StatisticsDTO>();
            summary.WaistStatistics = new List<StatisticsDTO>();
            summary.ThighStatistics = new List<StatisticsDTO>();
            summary.CalfStatistics = new List<StatisticsDTO>();
            summary.ExerciseStatistics = new List<StatisticsDTO>();

            foreach (var measurement in measurements)
            {
                if(query.WantsWeight)
                {
                    summary.WeightStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Weight
                    });
                }
                if (query.WantsBicep)
                {
                    summary.BicepStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Bicep
                    });
                }
                if (query.WantsForearm)
                {
                    summary.ForearmStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Forearm
                    });
                }
                if (query.WantsChest)
                {
                    summary.ChestStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Chest
                    });
                }
                if (query.WantsWaist)
                {
                    summary.WaistStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Waist
                    });
                }
                if (query.WantsThigh)
                {
                    summary.ThighStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Thigh
                    });
                }
                if (query.WantsCalf)
                {
                    summary.CalfStatistics.Add(new StatisticsDTO
                    {
                        Date = measurement.CreatedDate,
                        Statistic = measurement.Calf
                    });
                }
            }
            if (query.ExerciseName != "False")
            {
                foreach (var set in sets)
                {

                    summary.ExerciseStatistics.Add(new StatisticsDTO
                    {
                        Date = set.CreatedDate,
                        Statistic = set.Weight
                    });
                }
            }

            return summary;
        }
    }
}
