using AutoMapper;
using IIS_Projekat.Models.DTOs.Appointment;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppointmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewAppointmentByDoctorDTO appointment, string doctorsEmail)
        {
            throw new NotImplementedException();
        }

        public PaginationWrapper<PreviewAppointmentDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.AppointmentRepository.Filter(paginationQuery, a => a.Doctor, a => a.Doctor.Profile, a => a.Patient, a => a.Patient.Profile, a => a.Report);
            var result = new PaginationWrapper<PreviewAppointmentDTO>(_mapper.Map<List<PreviewAppointmentDTO>>(paginationResult.Items), paginationResult.TotalCount);
            return result;
        }
    }
}
