using IIS_Projekat.Models.DTOs.FoodPrice;

namespace IIS_Projekat.Services
{
    public interface IFoodPriceService
    {
        IEnumerable<PreviewFoodPricesDTO> GetAll();
        long CreateOrUpdate(NewFoodPriceDTO newFoodPriceDTO);
        void Delete(long id);
    }
}
