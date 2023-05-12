using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Recipe;

namespace IIS_Projekat.Services
{
    public interface IRecipeService
    {
        PaginationWrapper<PreviewRecipeDTO> GetAll(PaginationQuery paginationQuery);
        long Create(NewRecipeDTO newRecipeDTO);
        PreviewRecipeDetailedDTO GetDetailed(long id);
    }
}
