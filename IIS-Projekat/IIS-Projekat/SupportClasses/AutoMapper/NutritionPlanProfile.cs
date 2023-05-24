using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.NutritionPlan;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class NutritionPlanProfile : Profile
    {
        public NutritionPlanProfile()
        {
            CreateMap<NutritionPlan, PreviewNutritionPlanDTO>()
                .ForMember(np => np.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(np => np.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(np => np.UserEmail, opt => opt.MapFrom(src => src.User.Email));
        }
    }
}
