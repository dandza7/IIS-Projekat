namespace IIS_Projekat.Models.DTOs.Training
{
    public class ViewTrainingPlanRequestDTO
    {
        public long Id { get; set; }
        public string ClientFullName { get; set; }
        public int SessionsPerWeek { get; set; }
        public string TrainingGoal { get; set; }
    }
}
