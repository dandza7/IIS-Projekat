using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class FoodPrice : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long FoodId { get; set; }
        public Food Food { get; set; }
        public float Price { get; set; }
        public string Supplier { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
