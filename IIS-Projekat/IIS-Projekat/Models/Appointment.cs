using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Appointment : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public User Patient { get; set; }
        public User Doctor { get; set; }
        public long ReportId { get; set; }
        public Report Report { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
