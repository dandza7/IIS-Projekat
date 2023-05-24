using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class FoodOrder : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public float Amount { get; set; }
        public long FoodPriceId { get; set; }
        public FoodPrice FoodPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
