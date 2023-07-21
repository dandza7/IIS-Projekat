namespace IIS_Projekat.Models.DTOs.Training.Request
{
    public class TrainingPlanRequestDTO
    {
        public int SessionsPerWeek { get; set; }
        public string TrainingGoal { get; set; }
        public string TrainerEmail { get; set; }
    }
}
