namespace IIS_Projekat.Models.DTOs.Appointment
{
    public class NewAppointmentByDoctorDTO
    {
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public string PatientEmail { get; set; }
        public string ReportMessage { get; set; }
    }
}
