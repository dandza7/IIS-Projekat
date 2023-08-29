using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface IExerciseService
    {
        public long CreateExercise(NewExerciseDTO newExerciseDTO, string email);
        public PaginationWrapper<PreviewExerciseNameDTO> GetExercisesByPlan(PaginationQuery? paginationQuery, long clientId, string email);
        public PaginationWrapper<PreviewExerciseDTO> GetAll(PaginationQuery? paginationQuery);
        public PaginationWrapper<PreviewExerciseDTO> GetRehabilitationExercises(PaginationQuery? paginationQuery);
        public PaginationWrapper<PreviewExerciseDTO> GetSuitableExercisesForClient(long clientId, ExerciseFilterQuery query);
        public void FlagExercise(string email, FlagExerciseDTO flagDTO);
        public void DeleteExercise(long id);
    }
}
