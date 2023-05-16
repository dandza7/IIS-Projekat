using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class InjuryMedicalRecord : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Injury Injury { get; set; }
        public MedicalRecord MedicalRecord {get; set; }
        public string InjurySeverity { get; set; } = string.Empty;
    }
}
