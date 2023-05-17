namespace IIS_Projekat.Models.DTOs.Training
{
    public class PreviewDetailedTrainingPlanDTO
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public string TrainingGoal { get; set; }
        public string SessionsPerWeek { get; set; }
        public ICollection<PreviewTrainingSessionDTO> TrainingSessions { get; set; } = new List<PreviewTrainingSessionDTO>();
    }
}
