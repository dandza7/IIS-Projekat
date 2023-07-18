using AutoMapper;
using IIS_Projekat.Models.DTOs.Training.Plan;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Measurement;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class MeasurementProfile: Profile
    {
        public MeasurementProfile()
        {
            CreateMap<NewMeasurementDTO, Measurement>();
            CreateMap<Measurement, PreviewMeasurementDTO>();
        }
    }
}
