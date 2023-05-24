using IIS_Projekat.Models.DTOs.FoodPrice;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IFoodPriceService
    {
        PaginationWrapper<PreviewFoodPricesDTO> GetAll(int page);
        long CreateOrUpdate(NewFoodPriceDTO newFoodPriceDTO);
        void Delete(long id);
    }
}
