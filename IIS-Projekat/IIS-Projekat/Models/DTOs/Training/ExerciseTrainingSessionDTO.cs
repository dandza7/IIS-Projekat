namespace IIS_Projekat.Models.DTOs.Training
{
    public class ExerciseTrainingSessionDTO
    {
        public long TrainingSessionId { get; set; }
        public long ExerciseId { get; set; }
        public string RepetitionRange { get; set; }
        public int NumberOfSets { get; set; }
    }
}
