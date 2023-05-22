using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Appointment;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

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
            if (_unitOfWork.AppointmentRepository.GetAll(a => a.Doctor, a => a.Patient)
                .Where(a => (a.Doctor.Email == doctorsEmail)
                       && ((a.Beginning >= appointment.Beginning && a.Beginning <= appointment.Ending)
                       || (a.Ending >= appointment.Beginning && a.Ending <= appointment.Ending)
                       || (a.Beginning <= appointment.Beginning && a.Beginning >= appointment.Ending))).Any())
            {
                throw new DuplicateItemException("You have other appointment in this time interval!");
            }
            var newAppointment = _unitOfWork.AppointmentRepository.Create(_mapper.Map<Appointment>(appointment));
            var patient = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == appointment.PatientEmail).FirstOrDefault();
            if (patient == null)
            {
                throw new NotFoundException("Patient with sent email does not exist!");
            }
            var doctor = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == doctorsEmail).FirstOrDefault();
            if (doctor == null)
            {
                throw new NotFoundException("Doctor with sent email does not exist!");
            }
            newAppointment.Patient = patient;
            newAppointment.Doctor = doctor;
            newAppointment.Report = new Report
            {
                Message = appointment.ReportMessage
            };
            _unitOfWork.SaveChanges();
            return newAppointment.Id;
        }

        public PaginationWrapper<PreviewAppointmentDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.AppointmentRepository.Filter(paginationQuery, a => a.Doctor, a => a.Doctor.Profile, a => a.Patient, a => a.Patient.Profile, a => a.Report);
            var result = new PaginationWrapper<PreviewAppointmentDTO>(_mapper.Map<List<PreviewAppointmentDTO>>(paginationResult.Items), paginationResult.TotalCount);
            return result;
        }
    }
}
