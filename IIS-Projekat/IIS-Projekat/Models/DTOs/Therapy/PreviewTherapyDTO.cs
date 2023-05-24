using IIS_Projekat.Models.DTOs.MedicalRecord;

namespace IIS_Projekat.Models.DTOs.Therapy
{
    public class PreviewTherapyDTO
    {
        public PreviewMedicalRecordDTO MedicalRecord { get; set; }
        public string ReportMessage { get; set; }
    }
}
