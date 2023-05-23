using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class FoodSupplyReport : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public DateTime DeliveryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
