using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Allergy;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class AllergyProfile : Profile
    {
        public AllergyProfile()
        {
            CreateMap<Allergy, PreviewAllergyDTO>();
            CreateMap<NewAllergyDTO, Allergy>();
        }
    }
}
