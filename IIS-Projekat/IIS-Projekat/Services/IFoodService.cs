using IIS_Projekat.Models.DTOs.Food;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IFoodService
    {
        long Create(NewFoodDTO newFoodDTO);
        public PaginationWrapper<PreviewFoodDTO> GetAll(PaginationQuery paginationQuery);
    }
}
