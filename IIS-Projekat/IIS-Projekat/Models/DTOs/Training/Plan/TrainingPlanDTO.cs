namespace IIS_Projekat.Models.DTOs.Training.Plan
{
    public class TrainingPlanDTO
    {
        public long TrainingPlanRequestId { get; set; }
        public int SessionsPerWeek { get; set; }
        public string TrainingGoal { get; set; }
    }
}
