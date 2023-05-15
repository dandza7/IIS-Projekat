using AutoMapper;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingPlanProfile: Profile
    {
        public TrainingPlanProfile()
        {
            CreateMap<TrainingPlanDTO, TrainingPlan>();
        }
    }
}
