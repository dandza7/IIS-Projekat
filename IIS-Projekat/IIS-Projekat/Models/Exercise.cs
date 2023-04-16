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
        public MuscleGroup PrimaryTargetMuscle { get; set; }
        public ICollection<MuscleGroup> SecondaryTargetMuscles { get; set; } = new List<MuscleGroup>();
        public string Repetitions { get; set; }
        public TrainingSession TrainingSession { get; set; }
    }
}
