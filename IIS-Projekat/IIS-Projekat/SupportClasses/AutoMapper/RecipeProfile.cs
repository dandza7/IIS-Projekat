using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Recipe;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<NewRecipeDTO, Recipe>();
            CreateMap<Recipe, PreviewRecipeDTO>();
            CreateMap<Recipe, PreviewRecipeDetailedDTO>();
        }
    }
}
