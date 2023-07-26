using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.Services
{
    public interface ITrainingPlanRequestService
    {
        public PaginationWrapper<PreviewTrainingPlanRequestDTO> GetAllForTrainer(PaginationQuery? paginationQuery, string email);
        public long CreateTrainingPlanRequest(TrainingPlanRequestDTO trainingPlanRequestDTO, string email);
        public PreviewTrainingPlanRequestDTO GetById(long id);
        public void DeleteTrainingPlanRequest(long id);
    }
}
