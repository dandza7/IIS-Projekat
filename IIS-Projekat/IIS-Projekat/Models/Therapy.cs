using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Therapy : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string ReportMessage { get; set; }
        public ICollection<InjuredMuscleTherapy> InjuredMuscles { get; set; } = new List<InjuredMuscleTherapy>();
        public ICollection<Exercise> RecommendedExercises { get; set; } = new List<Exercise>();
        public MedicalRecord MedicalRecord { get; set; }
        public long MedicalRecordId { get; set; }
    }
}
