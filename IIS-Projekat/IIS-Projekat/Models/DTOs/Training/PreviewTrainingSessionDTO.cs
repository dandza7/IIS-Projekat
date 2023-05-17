namespace IIS_Projekat.Models.DTOs.Training
{
    public class PreviewTrainingSessionDTO
    {
        public string Name { get; set; }
        public ICollection<PreviewExerciseTrainingSessionDTO> ExerciseInfo { get; set; } = new List<PreviewExerciseTrainingSessionDTO>();
    }
}
