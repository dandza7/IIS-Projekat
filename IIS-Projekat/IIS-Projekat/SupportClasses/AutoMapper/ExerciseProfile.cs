using AutoMapper;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training;
using NewExerciseDTO = IIS_Projekat.Models.DTOs.Exercise.NewExerciseDTO;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<NewExerciseDTO, Exercise>();
            CreateMap<Exercise, PreviewExerciseDTO>()
                .ForMember(e => e.Type, opt => opt.MapFrom(src => src.IsHypertrophic ? "Hypertrophic" : "Rehabilitational"));
        }
    }
}
