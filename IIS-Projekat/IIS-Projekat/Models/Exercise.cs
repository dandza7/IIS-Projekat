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
        public bool IsHypertrophic { get; set; }
        public ICollection<ExerciseTrainingSession> TrainingSessions { get; set; } = new List<ExerciseTrainingSession>();
        public ICollection<ExerciseMuscleGroup> MuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
        public ICollection<TrainingSet> ExerciseSets { get; set; } = new List<TrainingSet>();
    }
}
