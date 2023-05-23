namespace IIS_Projekat.Models.DTOs.MedicalRecord
{
    public class PreviewMedicalRecord
    {
        public string PatientName { get; set; }
        public string Anamnesis { get; set; }
        public float Height { get; set; } = 0;
        public float Weight { get; set; } = 0;
    }
}
