using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.FoodPrice;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class FoodPricesProfile : Profile
    {
        public FoodPricesProfile()
        {
            CreateMap<FoodPrice, PreviewFoodPriceDTO>()
                .ForMember(fp => fp.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(fp => fp.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(fp => fp.Supplier, opt => opt.MapFrom(src => src.Supplier));
            CreateMap<Food, PreviewFoodPricesDTO>()
                .ForMember(fp => fp.FoodId, opt => opt.MapFrom(src => src.Id))
                .ForMember(fp => fp.FoodName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
