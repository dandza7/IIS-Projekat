﻿namespace IIS_Projekat.Models.DTOs.Training.Plan
{
    public class PreviewTrainingPlanDTO
    {
        public long TrainingPlanId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string TrainerName { get; set; }
        public string TrainingGoal { get; set; }
        public string SessionsPerWeek { get; set; }
    }
}
