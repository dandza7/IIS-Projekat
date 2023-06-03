using IIS_Projekat.Models.DTOs.FoodSupplying;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IFoodOrderingService
    {
        FoodSupplyingReportDTO CreateOrder(NewFoodOrderDTO newFoodOrderDTO);
        PaginationWrapper<FoodSupplyingReportDTO> GetAll(int page);
        DateTime UpdateOrdersStatus(OrderConfirmationDTO orderConfirmationDTO);
    }
}
