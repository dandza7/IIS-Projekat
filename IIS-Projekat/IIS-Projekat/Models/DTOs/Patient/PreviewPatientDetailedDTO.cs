namespace IIS_Projekat.Models.DTOs.Patient
{
    public class PreviewPatientDetailedDTO
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public List<string> Allergies { get; set; } = new List<string>();
        public List<string> Diagnoses { get; set; } = new List<string>();
        public string TrainingGoal { get; set; }
        public int SessionsPerWeek { get; set; }
    }
}
