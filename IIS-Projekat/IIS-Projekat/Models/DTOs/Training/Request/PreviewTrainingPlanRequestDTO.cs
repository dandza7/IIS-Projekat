namespace IIS_Projekat.Models.DTOs.Training.Request
{
    public class PreviewTrainingPlanRequestDTO
    {
        public long Id { get; set; }
        public string ClientFullName { get; set; }
        public int SessionsPerWeek { get; set; }
        public string TrainingGoal { get; set; }
    }
}
