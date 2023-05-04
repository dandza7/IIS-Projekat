using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Exercise : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public ICollection<TrainingSession> TrainingSessions { get; set; } = new List<TrainingSession>();
        public ICollection<ExerciseMuscleGroup> Exercises { get; set; } = new List<ExerciseMuscleGroup>();
    }
}
