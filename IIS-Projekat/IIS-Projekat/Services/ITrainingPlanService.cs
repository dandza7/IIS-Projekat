using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;

namespace IIS_Projekat.Services
{
    public interface ITrainingPlanService
    {
        public long CreateTrainingPlan(TrainingPlanDTO trainingPlanDTO);
        public PreviewDetailedTrainingPlanDTO GetDetailedTrainingPlanForTrainer(long id);
        public PaginationWrapper<PreviewTrainingPlanDTO> GetAll();
    }
}
