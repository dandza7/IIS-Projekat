using IIS_Projekat.Models.DTOs.Training.Set;

namespace IIS_Projekat.Models.DTOs.Training.Exercise
{
    public class PreviewDocumentedExerciseDTO
    {
        public string Name { get; set; }
        public ICollection<PreviewTrainingSetDTO> SetInfo = new List<PreviewTrainingSetDTO>();
    }
}
