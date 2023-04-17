using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingPlanRequestProfile : Profile
    {
        public TrainingPlanRequestProfile()
        {
            CreateMap<TrainingPlanRequestDTO, TrainingPlanRequest>();
            CreateMap<TrainingPlanRequest, ViewTrainingPlanRequestDTO>()
                .ForMember(tpr => tpr.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(tpr => tpr.SessionsPerWeek, opt => opt.MapFrom(src => src.SessionsPerWeek))
                .ForMember(tpr => tpr.TrainingGoal, opt => opt.MapFrom(src => src.TrainingGoal))
                .ForMember(tpr => tpr.ClientFullName, opt => opt.MapFrom(src => $"{src.Client.Profile.Name} {src.Client.Profile.Surname}"));
        }
    }
}
