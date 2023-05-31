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
            var appointment = _unitOfWork.AppointmentRepository.GetById(newTherapy.AppointmentId, a => a.Patient, a => a.Patient.MedicalRecord);
            if(appointment == null)
            {
                throw new NotFoundException($"Appointment with ID: {newTherapy.AppointmentId} does not exist.");
            }
            var therapy = _mapper.Map<Therapy>(newTherapy);
            therapy.MedicalRecord = appointment.Patient.MedicalRecord;
            therapy.MedicalRecordId = appointment.Patient.MedicalRecord.Id;

            DiagnoseInjuries(therapy, newTherapy);
            RecommendExercises(therapy, newTherapy.rehabilitationExercises);

            therapy = _unitOfWork.TherapyRepository.Create(therapy);
            _unitOfWork.AppointmentRepository.Delete(appointment);
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
            var injuriesDiagnosedInTherapy = _unitOfWork.InjuredMuscleTherapyRepository.GetAll().Where(imt => imt.Therapy == therapy).ToList();
            foreach(var injuryInTherapy in injuriesDiagnosedInTherapy)
            {
                _unitOfWork.InjuredMuscleTherapyRepository.Delete(injuryInTherapy);
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
                var patient = _unitOfWork.AppointmentRepository.GetById(therapyDTO.AppointmentId, a => a.Patient).Patient;
                var injuredMusclesInTherapy = new InjuredMuscleTherapy();
                injuredMusclesInTherapy.Therapy = therapy;
                injuredMusclesInTherapy.InjuredMuscle = injuredMuscle;
                injuredMusclesInTherapy.InjurySeverity = newInjury.Severity;
                injuredMusclesInTherapy = _unitOfWork.InjuredMuscleTherapyRepository.Create(injuredMusclesInTherapy);
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
    }
}
