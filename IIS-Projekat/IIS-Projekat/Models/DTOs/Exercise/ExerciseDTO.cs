namespace IIS_Projekat.Models.DTOs.Exercise
{
    public class ExerciseDTO
    {
        public string Name { get; set; }
        public string PrimaryMuscleGroup { get; set; }
        public ICollection<string> SecondaryMuscleGroups { get; set; }
        public bool IsHypertrophic { get; set; }
    }
}
