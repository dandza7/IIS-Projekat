using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Plan;

namespace IIS_Projekat.Services
{
    public interface ITrainingPlanService
    {
        public long CreateTrainingPlan(TrainingPlanDTO trainingPlanDTO);
        public long UpdateTrainingPlan(UpdateTrainingPlanDTO updateDTO, string email);
        public PreviewDetailedTrainingPlanDTO GetDetailedTrainingPlanForTrainer(long id);
        public PaginationWrapper<PreviewTrainingPlanDTO> GetAll(PaginationQuery paginationQuery);
        public PreviewTrainingPlanForClient GetTrainingPlanForClient(string email);
    }
}
