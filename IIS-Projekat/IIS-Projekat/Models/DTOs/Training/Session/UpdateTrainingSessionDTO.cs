namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class UpdateTrainingSessionDTO
    {
        public long TrainingPlanId { get; set; }
        public string OldSessionName { get; set; }
        public string NewSessionName { get; set; }
        public ICollection<UpdateExerciseTrainingSessionDTO> Exercises { get; set; } = new List<UpdateExerciseTrainingSessionDTO>();
    }
}
