using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.Models.DTOs.Appointment
{
    public class PreviewAppointmentDTO
    {
        public long Id { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public PreviewUsersProfileDTO Patient { get; set; }
        public PreviewUsersProfileDTO Doctor { get; set; }
        public string Report { get; set; }
    }
}
