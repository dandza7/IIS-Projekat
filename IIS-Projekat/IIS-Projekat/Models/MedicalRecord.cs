using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class MedicalRecord : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Anamnesis { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Therapy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
