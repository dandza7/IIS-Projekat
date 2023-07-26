using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.Models.DTOs.Training.Plan
{
    public class PreviewDetailedTrainingPlanDTO
    {
        public long TrainingPlanId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string TrainingGoal { get; set; }
        public string SessionsPerWeek { get; set; }
        public ICollection<PreviewTrainingSessionDTO> TrainingSessions { get; set; } = new List<PreviewTrainingSessionDTO>();
    }
}
