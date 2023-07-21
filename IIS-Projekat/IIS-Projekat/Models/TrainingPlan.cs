using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class TrainingPlan : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string TrainingGoal { get; set; }
        public int SessionsPerWeek { get; set; }
        public ICollection<TrainingSession> TrainingSessions { get; set; } = new List<TrainingSession>();
        public long ClientId { get; set; }
        public User Client { get; set; }
        public long TrainerId { get; set; }
        public User Trainer { get; set; }
    }
}
