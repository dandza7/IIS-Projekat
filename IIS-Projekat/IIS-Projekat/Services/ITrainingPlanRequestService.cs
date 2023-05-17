using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.Services
{
    public interface ITrainingPlanRequestService
    {
        public PaginationWrapper<PreviewTrainingPlanRequestDTO> GetAll(PaginationQuery? paginationQuery);
        public long CreateTrainingPlanRequest(TrainingPlanRequestDTO trainingPlanRequestDTO, string email);
    }
}
