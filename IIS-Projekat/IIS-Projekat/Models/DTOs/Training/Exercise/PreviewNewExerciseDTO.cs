using IIS_Projekat.Models.DTOs.Training.Set;

namespace IIS_Projekat.Models.DTOs.Training.Exercise
{
    public class PreviewNewExerciseDTO
    {
        public string Name { get; set; }
        public ICollection<PreviewNewTrainingSetDTO> SetInfo { get; set; } = new List<PreviewNewTrainingSetDTO>();
    }
}
