namespace IIS_Projekat.Models.DTOs.Exercise
{
    public class ExerciseFilterQuery
    {
        public string PrimaryMuscleGroup { get; set; } = string.Empty;
        public string SecondarymuscleGroup { get; set; } = string.Empty;
        public string ExerciseNature { get; set; } = "Both";
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}
