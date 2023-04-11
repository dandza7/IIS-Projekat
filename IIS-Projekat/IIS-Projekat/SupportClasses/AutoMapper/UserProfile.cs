using AutoMapper;
using IIS_Projekat.Models;
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
                .ForMember(up => up.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(up => up.Name, opt => opt.MapFrom(src => src.Profile.Name))
                .ForMember(up => up.Surname, opt => opt.MapFrom(src => src.Profile.Surname))
                .ForMember(up => up.BirthDate, opt => opt.MapFrom(src => src.Profile.BirthDate))
                .ForMember(up => up.Gender, opt => opt.MapFrom(src => src.Profile.Gender))
                .ForMember(up => up.Role, opt => opt.MapFrom(src => src.Role));

        }
    }
}
