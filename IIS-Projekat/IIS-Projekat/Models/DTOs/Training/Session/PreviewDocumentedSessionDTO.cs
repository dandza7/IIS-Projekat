using IIS_Projekat.Models.DTOs.Training.Exercise;
using IIS_Projekat.Models.DTOs.Training.Set;

namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class PreviewDocumentedSessionDTO
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PreviewDocumentedExerciseDTO> ExerciseInfo { get; set; } = new List<PreviewDocumentedExerciseDTO>();
    }
}
