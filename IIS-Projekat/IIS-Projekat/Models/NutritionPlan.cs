using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class NutritionPlan : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public ICollection<Meal> Meals { get; set; } = new List<Meal>();
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
