using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training.Plan;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingPlanProfile: Profile
    {
        public TrainingPlanProfile()
        {
            CreateMap<TrainingPlanDTO, TrainingPlan>().ForMember(tp => tp.TrainingSessions, opt => opt.Ignore());
            CreateMap<TrainingPlan, PreviewTrainingPlanDTO>();
            CreateMap<TrainingPlan, PreviewDetailedTrainingPlanDTO>();
            CreateMap<TrainingPlan, PreviewTrainingPlanForClient>().ForMember(tp => tp.TrainingSessions, opt => opt.Ignore());
        }
    }
}
