namespace IIS_Projekat.Models.DTOs.MedicalRecord
{
    public class MedicalRecordDTO
    {
        public string Anamnesis { get; set; }
        public float Height { get; set; } = 0;
        public float Weight { get; set; } = 0;
        public long PatientId { get; set; }
    }
}
