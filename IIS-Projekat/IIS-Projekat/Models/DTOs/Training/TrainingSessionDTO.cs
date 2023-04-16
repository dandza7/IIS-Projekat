namespace IIS_Projekat.Models.DTOs.Training
{
    public class TrainingSessionDTO
    {
        public long TrainingSessionId { get; set; }
        public IList<ExerciseDTO> Exercises { get; set; }
    }
}
