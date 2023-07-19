using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class ExerciseTrainingSession: IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Exercise Exercise { get; set; }
        public TrainingSession TrainingSession { get; set; }
        public string RepetitionRange { get; set; }
        public int NumberOfSets { get; set; }
        public bool IsUnhappy { get; set; } = false;
        public string Note { get; set; } = "";
    }
}
