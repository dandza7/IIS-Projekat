using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.FoodSupplying;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class FoodOrderingProfile : Profile
    {
        public FoodOrderingProfile()
        {
            CreateMap<FoodOrder, PreviewFoodOrderDTO>()
                .ForMember(fo => fo.FoodName, opt => opt.MapFrom(src => src.FoodPrice.Food.Name))
                .ForMember(fo => fo.Price, opt => opt.MapFrom(src => src.FoodPrice.Price))
                .ForMember(fo => fo.Supplier, opt => opt.MapFrom(src => src.FoodPrice.Supplier))
                .ForMember(fo => fo.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}
