using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Appointment;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<NewAppointmentByDoctorDTO, Appointment>();
            CreateMap<Appointment, PreviewAppointmentDTO>();
        }
    }
}
