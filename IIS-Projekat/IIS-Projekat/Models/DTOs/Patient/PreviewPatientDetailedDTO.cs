using IIS_Projekat.Models.DTOs.Injury;
using IIS_Projekat.Models.DTOs.Measurement;

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
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Anamnesis { get; set; }
        public List<string> Allergies { get; set; } = new List<string>();
        public List<string> Diagnoses { get; set; } = new List<string>();
        public List<PreviewInjuryDTO> Injuries { get; set; } = new List<PreviewInjuryDTO>();
        public List<PreviewMeasurementDTO> Measurements { get; set; } = new List<PreviewMeasurementDTO>();
        public string TrainingGoal { get; set; }
        public int SessionsPerWeek { get; set; }
    }
}
