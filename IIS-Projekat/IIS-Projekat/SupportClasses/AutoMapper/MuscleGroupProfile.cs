using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.MuscleGroup;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class MuscleGroupProfile: Profile
    {
        public MuscleGroupProfile()
        {
            CreateMap<MuscleGroup, MuscleGroupDTO>();
        }
    }
}
