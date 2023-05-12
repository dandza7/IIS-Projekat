using AutoMapper;
using IIS_Projekat.Models;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, String>().ConvertUsing(r => r.Message);
        }
    }
}
