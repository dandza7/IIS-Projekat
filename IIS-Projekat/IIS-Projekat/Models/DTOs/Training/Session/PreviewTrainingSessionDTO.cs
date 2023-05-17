namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class PreviewTrainingSessionDTO
    {
        public string Name { get; set; }
        public ICollection<PreviewExerciseTrainingSessionDTO> ExerciseInfo { get; set; } = new List<PreviewExerciseTrainingSessionDTO>();
    }
}
