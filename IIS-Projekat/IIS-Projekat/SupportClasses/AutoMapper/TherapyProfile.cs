using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Therapy;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TherapyProfile: Profile
    {
        public TherapyProfile()
        {
            CreateMap<TherapyDTO, Therapy>();
            CreateMap<Therapy, PreviewTherapyDTO>();
        }
    }
}
