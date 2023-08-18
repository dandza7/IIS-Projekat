using IIS_Projekat.Models.DTOs.Training.Exercise;

namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class PreviewNewTrainingSessionDTO
    {
        public string Name { get; set; }

        public ICollection<PreviewNewExerciseDTO> ExerciseInfo { get; set; } = new List<PreviewNewExerciseDTO>();
    }
}
