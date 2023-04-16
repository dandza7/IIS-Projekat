namespace IIS_Projekat.Models.DTOs.Training
{
    public class TrainingPlanResponseDTO
    {
        public long TrainingPlanId { get; set; }
        public IList<TrainingSessionDTO> TrainingSessions { get; set; }
    }
}
