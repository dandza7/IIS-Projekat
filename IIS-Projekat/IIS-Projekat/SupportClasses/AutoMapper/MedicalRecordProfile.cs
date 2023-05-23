using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.MedicalRecord;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class MedicalRecordProfile: Profile
    {
        public MedicalRecordProfile()
        {
            CreateMap<MedicalRecordDTO, MedicalRecord>();
        }
    }
}
