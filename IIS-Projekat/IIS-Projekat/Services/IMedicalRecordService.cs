using IIS_Projekat.Models.DTOs.MedicalRecord;

namespace IIS_Projekat.Services
{
    public interface IMedicalRecordService
    {
        public long Create(MedicalRecordDTO newMedicalRecord);
    }
}
