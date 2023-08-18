using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace IIS_Projekat.Models
{
    public class TrainingSet : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Exercise Exercise { get; set; }
        public long ExerciseId { get; set; }
        public float Weight { get; set; }
        public int Repetitions { get; set; }
        public TrainingSession TrainingSession { get; set; }
        public long TrainingSessionId { get; set; }
    }
}
