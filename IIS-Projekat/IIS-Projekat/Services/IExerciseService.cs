using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IExerciseService
    {
        //public PaginationWrapper<ExerciseDTO> GetAll(PaginationQuery? paginationQuery);
        public long CreateExercise(NewExerciseDTO newExerciseDTO);
        public void DeleteExercise(long id);
    }
}
