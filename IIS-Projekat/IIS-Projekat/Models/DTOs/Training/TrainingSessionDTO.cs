namespace IIS_Projekat.Models.DTOs.Training
{
    public class TrainingSessionDTO
    {
        public long TrainingSessionId { get; set; }
        public ICollection<ExerciseDTO> Exercises { get; set; } = new List<ExerciseDTO>();
    }
}
