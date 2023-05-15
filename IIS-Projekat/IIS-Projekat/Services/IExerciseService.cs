using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IExerciseService
    {
        public long CreateExercise(ExerciseDTO newExerciseDTO);
        public PaginationWrapper<ExercisePreviewDTO> GetAll(PaginationQuery? paginationQuery);
        public void DeleteExercise(long id);
    }
}
