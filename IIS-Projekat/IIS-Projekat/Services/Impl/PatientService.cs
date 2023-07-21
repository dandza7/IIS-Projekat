using AutoMapper;
using IIS_Projekat.Models.DTOs.Injury;
using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Services.Impl
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PatientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public PaginationWrapper<PreviewUsersProfileDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.UserRepository.Filter(paginationQuery, u => u.Profile);
            return new PaginationWrapper<PreviewUsersProfileDTO>(_mapper.Map<List<PreviewUsersProfileDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public PreviewPatientDetailedDTO GetPatientDetailed(long id)
        {
            var patient = _unitOfWork.UserRepository.GetById(id, u => u.MedicalRecord, u => u.MedicalRecord.Allergies, u => u.MedicalRecord.Diagnoses, u => u.Profile);
            if (patient == null)
            {
                throw new NotFoundException($"Patient with sent ID {id} is not found!");
            }
            var detailedDTO = _mapper.Map<PreviewPatientDetailedDTO>(patient);
            var medicalRecord = _unitOfWork.MedicalRecordRepository
                .GetAll(mr => mr.Measurements)
                .Where(mr => mr.PatientId == id).Include(mr => mr.Therapies).
                ThenInclude(t => t.InjuredMuscles).ThenInclude(im => im.InjuredMuscle).FirstOrDefault();
            if (medicalRecord == null)
            {
                throw new NotFoundException($"Patient with ID: {id} does not have a medical record.");
            }
            var patientIjuries = new List<PreviewInjuryDTO>();
            foreach (var therapy in medicalRecord.Therapies)
            {
                foreach (var injury in therapy.InjuredMuscles)
                {
                    var injuryDTO = new PreviewInjuryDTO()
                    {
                        InjuredMuscle = injury.InjuredMuscle.Name,
                        Severity = injury.InjurySeverity
                    };
                    patientIjuries.Add(injuryDTO);
                }
            }
            detailedDTO.Injuries = patientIjuries;
            detailedDTO.Measurements = _mapper.Map<List<PreviewMeasurementDTO>>(medicalRecord.Measurements);
            detailedDTO.Weight = medicalRecord.Measurements.Last().Weight;
            var trainingPlan = _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.ClientId == id).FirstOrDefault();
            detailedDTO.TrainingGoal = (trainingPlan == null) ? "No plan" : trainingPlan.TrainingGoal;
            detailedDTO.SessionsPerWeek = (trainingPlan == null) ? 0 : trainingPlan.SessionsPerWeek;
            return detailedDTO;
        }
    }
}
