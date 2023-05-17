namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class TrainingSessionDTO
    {
        public long TrainingPlanId { get; set; }
        public string Name { get; set; }
        public ICollection<ExerciseTrainingSessionDTO> ExerciseInfo { get; set; } = new List<ExerciseTrainingSessionDTO>();
    }
}
