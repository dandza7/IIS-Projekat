namespace IIS_Projekat.Models.DTOs.Training.Plan
{
    public class UpdateTrainingPlanDTO
    {
        public long TrainingPlanId { get; set; }
        public int SessionsPerWeek { get; set; }
        public string TrainingGoal { get; set; }
        public long TrainerId { get; set; }
        public long ClientId { get; set; }
        public ICollection<TrainingSessionWithPlanDTO> TrainingSessions { get; set; } = new List<TrainingSessionWithPlanDTO>();
    }
}
