using IIS_Projekat.Models.DTOs.Appointment;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IAppointmentService
    {
        long Create(NewAppointmentByDoctorDTO appointment, string doctorsEmail);
        PaginationWrapper<PreviewAppointmentDTO> GetAll(PaginationQuery paginationQuery);
    }
}
