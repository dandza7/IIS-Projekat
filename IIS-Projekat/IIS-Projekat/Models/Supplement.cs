using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Supplement: IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public float Dose { get; set; }
        public ICollection<NutritionPlan> NutritionPlans { get; set; } = new List<NutritionPlan>();
    }
}
