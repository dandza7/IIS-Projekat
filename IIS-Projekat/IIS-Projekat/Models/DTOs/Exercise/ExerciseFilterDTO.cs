namespace IIS_Projekat.Models.DTOs.Exercise
{
    public class ExerciseFilterDTO
    {
        public string PrimaryMuscleGroup { get; set; } = string.Empty;
        public string SecondarymuscleGroup { get; set; } = string.Empty;
        public string ExerciseNature { get; set; } = "Both";
    }
}
