using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, PreviewUserDTO>();
            CreateMap<NewUserDTO, User>();
        }
    }
}
