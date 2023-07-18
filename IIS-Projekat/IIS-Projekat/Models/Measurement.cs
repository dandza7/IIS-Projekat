using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Measurement: IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public float Weight { get; set; }
        public float Bicep { get; set; }
        public float Forearm { get; set; }
        public float Chest { get; set; }
        public float Waist { get; set; }
        public float Thigh { get; set; }
        public float Calf { get; set; }
    }
}
