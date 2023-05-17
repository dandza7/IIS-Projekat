using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models;
using AutoMapper;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class ExerciseTrainingSessionProfile: Profile
    {
        public ExerciseTrainingSessionProfile()
        {
            CreateMap<ExerciseTrainingSession, PreviewExerciseTrainingSessionDTO>()
                .ForMember(ets => ets.ExerciseName, opt => opt.MapFrom(src => src.Exercise.Name))
                .ForMember(ets => ets.NumberOfSets, opt => opt.MapFrom(src => src.NumberOfSets))
                .ForMember(ets => ets.RepetitionRange, opt => opt.MapFrom(src => src.RepetitionRange));
        }
    }
}
