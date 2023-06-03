namespace IIS_Projekat.Models.DTOs.FoodSupplying
{
    public class FoodSupplyingReportDTO
    {
        public long ReportId { get; set; }
        public List<PreviewFoodOrderDTO> FoodOrders { get; set; } = new List<PreviewFoodOrderDTO>();
        public List<long> PlansIds { get; set; }
        public DateTime DeliveryDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
