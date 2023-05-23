using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Injury;
using IIS_Projekat.Models.DTOs.Therapy;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class TherapyService : ITherapyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TherapyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(TherapyDTO newTherapy)
        {
            var patient = _unitOfWork.UserRepository.GetById(newTherapy.PatientId, p => p.MedicalRecord);
            if(patient == null)
            {
                throw new NotFoundException($"Patient with ID: {newTherapy.PatientId} does not exist.");
            }
            var therapy = _mapper.Map<Therapy>(newTherapy);
            therapy.MedicalRecord = patient.MedicalRecord;
            therapy.MedicalRecordId = patient.MedicalRecord.Id;

            foreach(var exerciseName in newTherapy.rehabilitationExercises)
            {
                ConnectTherapyAndExercise(therapy, exerciseName);
            }
            therapy = _unitOfWork.TherapyRepository.Create(therapy);

            foreach (var injuryDTO in newTherapy.Injuries)
            {
                DiagnoseInjury(newTherapy.PatientId, injuryDTO);
            }

            _unitOfWork.SaveChanges();
            return therapy.Id;
        }

        private void ConnectTherapyAndExercise(Therapy therapy, string exerciseName)
        {
            var exercise = _unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == exerciseName).FirstOrDefault();
            if (exercise == null)
            {
                throw new NotFoundException($"Exercise {exerciseName} does not exist in the database.");
            }
            therapy.RecommendedExercises.Add(exercise);
            exercise.Therapies.Add(therapy);
        }

        private void DiagnoseInjury(long patientId, InjuryDTO newInjury)
        {
            var injuredMuscle = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == newInjury.InjuredMuscle).FirstOrDefault();
            if (injuredMuscle == null)
            {
                throw new NotFoundException($"Muscle group with name: {newInjury.InjuredMuscle} was not found.");
            }
            var injury = _unitOfWork.InjuryRepository.GetAll().Where(i => i.Muscle == injuredMuscle).FirstOrDefault();
            var patient = _unitOfWork.UserRepository.GetById(patientId, p => p.MedicalRecord);
            if (patient == null)
            {
                throw new NotFoundException($"Patient does not exist.");
            }
            if (injury == null) injury = CreateInjuryBase(injuredMuscle);
            var injuryMedicalRecord = new InjuryMedicalRecord();
            injuryMedicalRecord.Injury = injury;
            injuryMedicalRecord.MedicalRecord = patient.MedicalRecord;
            injuryMedicalRecord.InjurySeverity = newInjury.Severity;

            injuryMedicalRecord = _unitOfWork.InjuryMedicalRecordRepository.Create(injuryMedicalRecord);
        }

        private Injury CreateInjuryBase(MuscleGroup injuredMuscle)
        {
            var injury = new Injury();
            injury.Muscle = injuredMuscle;
            injury = _unitOfWork.InjuryRepository.Create(injury);
            return injury;
        }
    }
}
