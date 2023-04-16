namespace IIS_Projekat.Models.DTOs.Training
{
    public class FinishedTrainingPlanDTO
    {
        public long TrainingPlanId { get; set; }
        public IList<TrainingSessionDTO> TrainingSessions { get; set; }
    }
}
