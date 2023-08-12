using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Supplement;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class SupplementProfile: Profile
    {
        public SupplementProfile()
        {
            CreateMap<Supplement, PreviewSupplementDTO>();
            CreateMap<UpdateSupplementDTO, Supplement>();
            CreateMap<NewSupplementDTO, Supplement>();
        }
    }
}
