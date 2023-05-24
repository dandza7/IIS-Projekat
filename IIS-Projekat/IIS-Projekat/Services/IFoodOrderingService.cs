using IIS_Projekat.Models.DTOs.FoodSupplying;

namespace IIS_Projekat.Services
{
    public interface IFoodOrderingService
    {
        FoodSupplyingReportDTO CreateOrder(NewFoodOrderDTO newFoodOrderDTO);
    }
}
