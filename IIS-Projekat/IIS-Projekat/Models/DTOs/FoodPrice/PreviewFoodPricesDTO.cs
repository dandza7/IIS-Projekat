namespace IIS_Projekat.Models.DTOs.FoodPrice
{
    public class PreviewFoodPricesDTO
    {
        public long FoodId { get; set; }
        public string FoodName { get; set; }
        public List<PreviewFoodPriceDTO> FoodPrices { get; set; } = new List<PreviewFoodPriceDTO>();
    }
}
