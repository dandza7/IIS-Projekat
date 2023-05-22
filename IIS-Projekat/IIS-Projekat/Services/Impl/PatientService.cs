using AutoMapper;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

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
            var patientDetailed = _mapper.Map<PreviewPatientDetailedDTO>(patient);
            var plan = _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.Client.Id == id).FirstOrDefault();
            patientDetailed.SessionsPerWeek = plan == null ? 0 : plan.TrainingSessions.Count();
            patientDetailed.TrainingGoal = plan == null ? "No plan" : plan.TrainingGoal;
            return patientDetailed;
        }
    }
}
