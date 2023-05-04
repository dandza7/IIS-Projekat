namespace IIS_Projekat.Models.DTOs.Exercise
{
    public class NewExerciseDTO
    {
        public string Name { get; set; }
        public string PrimaryMuscleGroup { get; set; }
        public ICollection<string> SecondaryMuscleGroups { get; set; }
    }
}
