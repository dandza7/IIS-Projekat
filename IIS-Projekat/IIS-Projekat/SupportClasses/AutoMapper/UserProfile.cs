using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, PreviewUserDTO>();
            CreateMap<NewUserDTO, User>();
            CreateMap<User, PreviewUsersProfileDTO>()
                .ForMember(up => up.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(up => up.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(up => up.Name, opt => opt.MapFrom(src => src.Profile.Name))
                .ForMember(up => up.Surname, opt => opt.MapFrom(src => src.Profile.Surname))
                .ForMember(up => up.BirthDate, opt => opt.MapFrom(src => src.Profile.BirthDate))
                .ForMember(up => up.Gender, opt => opt.MapFrom(src => src.Profile.Gender))
                .ForMember(up => up.Role, opt => opt.MapFrom(src => src.Role));
            CreateMap<User, PreviewPatientDetailedDTO>()
                .ForMember(up => up.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(up => up.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(up => up.Name, opt => opt.MapFrom(src => src.Profile.Name))
                .ForMember(up => up.Surname, opt => opt.MapFrom(src => src.Profile.Surname))
                .ForMember(up => up.BirthDate, opt => opt.MapFrom(src => src.Profile.BirthDate))
                .ForMember(up => up.Gender, opt => opt.MapFrom(src => src.Profile.Gender))
                .ForMember(up => up.Height, opt => opt.MapFrom(src => src.MedicalRecord.Height))
                .ForMember(up => up.Weight, opt => opt.MapFrom(src => src.MedicalRecord.Weight))
                .ForMember(up => up.Allergies, opt => opt.MapFrom(src => src.MedicalRecord.Allergies.Select(a => a.Name)))
                .ForMember(up => up.Diagnoses, opt => opt.MapFrom(src => src.MedicalRecord.Diagnoses.Select(a => a.Name)))
                .ForMember(up => up.Anamnesis, opt => opt.MapFrom(src => src.MedicalRecord.Anamnesis));
        }
    }
}
