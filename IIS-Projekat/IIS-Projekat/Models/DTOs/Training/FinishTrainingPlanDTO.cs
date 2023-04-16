namespace IIS_Projekat.Models.DTOs.Training
{
    public class FinishTrainingPlanDTO
    {
        public long ClientId { get; set; }
        public int SessionsPerWeek { get; set; }
        public Goal TrainingGoal { get; set; }
    }
}
