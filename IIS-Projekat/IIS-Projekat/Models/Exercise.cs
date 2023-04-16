using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public enum RepetionRange
    {
        Low, //5-8
        Average, //8-12
        High, //12-15
        VeryHigh //12-20
    };

    public enum TargetMuscles
    {
        Calves,
        Quads,
        Hamstring,
        Abductors,
        Adductors, 
        Gluteus,
        Core,
        Abs,
        LowerBack,
        Lats,
        TeresMajor,
        LowerTraps,
        Traps,
        BackDelts,
        SideDelts,
        FrontDelts,
        UpperChest,
        LowerChest,
        Biceps,
        Brachialis, 
        Triceps, 
        Forearms
    };

    public class Exercise : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public TargetMuscles PrimaryTargetMuscle { get; set; }
        public IList<TargetMuscles> SeconaryTargetMuscles { get; set; }
        public RepetionRange Repetitions { get; set; }
    }
}
