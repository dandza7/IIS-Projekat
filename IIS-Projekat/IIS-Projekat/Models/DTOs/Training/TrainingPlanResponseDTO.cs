namespace IIS_Projekat.Models.DTOs.Training
{
    public class TrainingPlanResponseDTO
    {
        public long TrainingPlanId { get; set; }
        public ICollection<TrainingSessionDTO> TrainingSessions { get; set; } = new List<TrainingSessionDTO>();
    }
}
