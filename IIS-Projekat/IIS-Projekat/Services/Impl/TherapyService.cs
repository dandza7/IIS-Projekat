using System.Linq.Dynamic.Core;
using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Injury;
using IIS_Projekat.Models.DTOs.MedicalRecord;
using IIS_Projekat.Models.DTOs.Pagination;
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

            DiagnoseInjuries(therapy, newTherapy);
            RecommendExercises(therapy, newTherapy.rehabilitationExercises);

            therapy = _unitOfWork.TherapyRepository.Create(therapy);
            _unitOfWork.SaveChanges();
            return therapy.Id;
        }
        public void Delete(long id)
        {
            var therapy = _unitOfWork.TherapyRepository.GetById(id);
            if(therapy == null)
            {
                throw new NotFoundException($"Therapy with ID: {id} does not exist in the database.");
            }
            var injuriesDiagnosedInTherapy = _unitOfWork.InjuryTherapyRepository.GetAll(it => it.Injury).Where(it => it.Therapy == therapy).ToList();
            foreach(var injuryInTherapy in injuriesDiagnosedInTherapy)
            {
                _unitOfWork.InjuryTherapyRepository.Delete(injuryInTherapy);
            }
            _unitOfWork.TherapyRepository.Delete(therapy);
            _unitOfWork.SaveChanges();
        }

        public PaginationWrapper<PreviewTherapyDTO> GetAll(PaginationQuery? paginationQuery)
        {
            ICollection<PreviewTherapyDTO> therapiyDTOs = new List<PreviewTherapyDTO>();
            foreach(var therapy in _unitOfWork.TherapyRepository.GetAll(t => t.MedicalRecord, t => t.MedicalRecord.Patient, t => t.MedicalRecord.Patient.Profile))
            {
                var therapyDTO = _mapper.Map<PreviewTherapyDTO>(therapy);
                therapyDTO.MedicalRecord = _mapper.Map<PreviewMedicalRecordDTO>(therapy.MedicalRecord);
                therapiyDTOs.Add(therapyDTO);
            }
            return new PaginationWrapper<PreviewTherapyDTO>(therapiyDTOs.ToList(), therapiyDTOs.Count);
        }

        public PreviewTherapyDTO GetById(long id)
        {
            var therapy = _unitOfWork.TherapyRepository.GetById(id, t => t.MedicalRecord, t => t.MedicalRecord.Patient, t => t.MedicalRecord.Patient.Profile);
            var therapyDTO = _mapper.Map<PreviewTherapyDTO>(therapy);
            therapyDTO.MedicalRecord = _mapper.Map<PreviewMedicalRecordDTO>(therapy.MedicalRecord);
            return therapyDTO;
        }

        private void DiagnoseInjuries(Therapy therapy, TherapyDTO therapyDTO)
        {
            foreach(var newInjury in therapyDTO.Injuries)
            {
                var injuredMuscle = _unitOfWork.MuscleGroupRepository.GetAll().Where(mg => mg.Name == newInjury.InjuredMuscle).FirstOrDefault();
                if (injuredMuscle == null)
                {
                    throw new NotFoundException($"Muscle group with name: {newInjury.InjuredMuscle} was not found.");
                }
                var patient = _unitOfWork.UserRepository.GetById(therapyDTO.PatientId, p => p.MedicalRecord);
                var injury = _unitOfWork.InjuryRepository.GetAll().Where(i => i.Muscle == injuredMuscle).FirstOrDefault();
                if (injury == null) injury = CreateInjuryBase(injuredMuscle);
                var injuryInTherapy = new InjuryTherapy();
                injuryInTherapy.Therapy = therapy;
                injuryInTherapy.Injury = injury;
                injuryInTherapy.InjurySeverity = newInjury.Severity;
                injuryInTherapy = _unitOfWork.InjuryTherapyRepository.Create(injuryInTherapy);
            }
        }
        private void RecommendExercises(Therapy therapy, ICollection<string> exercises)
        {
            foreach(string exerciseName in exercises)
            {
                var exercise = _unitOfWork.ExerciseRepository.GetAll().Where(e => e.Name == exerciseName).FirstOrDefault();
                if (exercise == null)
                {
                    throw new NotFoundException($"Exercise {exerciseName} does not exist in the database.");
                }
                therapy.RecommendedExercises.Add(exercise);
            }
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
