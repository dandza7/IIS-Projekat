using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Food;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<NewFoodDTO, Food>();
            CreateMap<Food, PreviewFoodDTO>()
                .ForMember(f => f.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(f => f.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(f => f.Calories, opt => opt.MapFrom(src => src.Calories))
                .ForMember(f => f.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(f => f.Allergies, opt => opt.MapFrom(src => src.Allergies.Select(a => a.Name)));
        }
    }
}
