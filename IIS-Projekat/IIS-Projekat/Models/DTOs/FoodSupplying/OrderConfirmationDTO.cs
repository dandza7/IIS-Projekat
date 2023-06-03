namespace IIS_Projekat.Models.DTOs.FoodSupplying
{
    public class OrderConfirmationDTO
    {
        public long Id { get; set; }
        public List<long> PlansIds { get; set; }
        public bool ToConfirm { get; set; }
    }
}
