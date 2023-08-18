namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class NewDocumentedTrainingSessionDTO
    {
        public string Name { get; set; }
        public ICollection<NewDocumentedTrainingSessionDTO> ExerciseInfo = new List<NewDocumentedTrainingSessionDTO>();
    }
}
