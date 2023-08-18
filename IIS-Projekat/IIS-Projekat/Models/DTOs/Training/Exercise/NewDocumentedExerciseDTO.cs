using IIS_Projekat.Models.DTOs.Training.Set;

namespace IIS_Projekat.Models.DTOs.Training.Exercise
{
    public class NewDocumentedExerciseDTO
    {
        public string Name { get; set; }
        public ICollection<NewTrainingSetDTO> SetInfo = new List<NewTrainingSetDTO>();
    }
}
