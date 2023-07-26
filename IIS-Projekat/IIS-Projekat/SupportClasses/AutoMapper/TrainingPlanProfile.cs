using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training.Plan;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingPlanProfile: Profile
    {
        public TrainingPlanProfile()
        {
            CreateMap<TrainingPlanDTO, TrainingPlan>()
                .ForMember(tp => tp.TrainingSessions, opt => opt.Ignore());
            CreateMap<TrainingPlan, PreviewTrainingPlanDTO>()
                .ForMember(tp => tp.TrainerName, opt => opt.MapFrom(src => $"{src.Trainer.Profile.Name} {src.Trainer.Profile.Surname}"))
                .ForMember(tp => tp.TrainingPlanId, opt => opt.MapFrom(src => src.Id));
            CreateMap<TrainingPlan, PreviewDetailedTrainingPlanDTO>().ForMember(tp => tp.TrainingPlanId, opt => opt.MapFrom(src => src.Id));
            CreateMap<TrainingPlan, PreviewTrainingPlanForClient>()
                .ForMember(tp => tp.TrainingSessions, opt => opt.Ignore())
                .ForMember(tp => tp.TrainerName, opt => opt.MapFrom(src => $"{src.Trainer.Profile.Name} {src.Trainer.Profile.Surname}"));
        }
    }
}
