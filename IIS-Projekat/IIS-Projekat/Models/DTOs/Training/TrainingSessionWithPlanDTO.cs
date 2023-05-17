namespace IIS_Projekat.Models.DTOs.Training
{
    public class TrainingSessionWithPlanDTO
    {
        public string Name { get; set; }
        public ICollection<ExerciseWithTrainingSessionDTO> Exercises { get; set; } = new List<ExerciseWithTrainingSessionDTO>();
    }
}
