using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;

namespace IIS_Projekat.Services
{
    public interface ITrainingPlanService
    {
        //public PaginationWrapper<ViewTrainingPlanDTO> GetAll(PaginationQuery? paginationQuery);
        public long CreateTrainingPlan(TrainingPlanDTO trainingPlanDTO);
    }
}
