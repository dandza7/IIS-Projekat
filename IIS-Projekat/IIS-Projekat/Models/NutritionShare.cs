using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class NutritionShare : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public int Share { get; set; }
        public string Unit { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
