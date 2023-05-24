namespace IIS_Projekat.Models.DTOs.FoodSupplying
{
    public class FoodSupplyingReportDTO
    {
        public List<PreviewFoodOrderDTO> FoodOrders { get; set; } = new List<PreviewFoodOrderDTO>();
        public DateTime DeliveryDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
