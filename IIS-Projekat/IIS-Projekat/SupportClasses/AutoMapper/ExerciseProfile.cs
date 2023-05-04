using AutoMapper;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<NewExerciseDTO, Exercise>();
        }
    }
}
