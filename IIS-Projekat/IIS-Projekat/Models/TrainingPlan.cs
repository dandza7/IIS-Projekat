using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public enum Goal
    {
        Bulk, 
        Cut, 
        Recomp,
        Endurance
    };

    public class TrainingPlan : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Goal TrainingGoal { get; set; }
        public int SessionsPerWeek { get; set; }
    }
}
