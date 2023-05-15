using AutoMapper;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingSessionProfile: Profile
    {
        public TrainingSessionProfile()
        {
            CreateMap<TrainingSessionDTO, TrainingSession>();
        }
    }
}
