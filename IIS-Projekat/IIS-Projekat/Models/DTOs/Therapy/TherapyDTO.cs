using IIS_Projekat.Models.DTOs.Injury;

namespace IIS_Projekat.Models.DTOs.Therapy
{
    public class TherapyDTO
    {
        public long PatientId { get; set; }
        public ICollection<InjuryDTO> Injuries { get; set; } = new List<InjuryDTO>();
        public ICollection<string> rehabilitationExercises { get; set; } = new List<string>();
    }
}
