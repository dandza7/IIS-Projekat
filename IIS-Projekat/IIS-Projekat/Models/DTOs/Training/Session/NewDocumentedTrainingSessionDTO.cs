using IIS_Projekat.Models.DTOs.Training.Exercise;

namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class NewDocumentedTrainingSessionDTO
    {
        public string Name { get; set; }
        public ICollection<NewDocumentedExerciseDTO> ExerciseInfo { get; set; } = new List<NewDocumentedExerciseDTO>();
    }
}
