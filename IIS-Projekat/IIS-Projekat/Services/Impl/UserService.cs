using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses;
using IIS_Projekat.SupportClasses.Roles;

namespace IIS_Projekat.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<PreviewUserDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<PreviewUserDTO>>(_unitOfWork.UserRepository.GetAll().ToList());
        }

        public long Register(NewUserDTO newUserDTO)
        {
            var user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == newUserDTO.Email);
            if (user != null)
            {
                return 0L;
            }
            var newUser = new User();
            newUser.Email = newUserDTO.Email;
            byte[] salt;
            newUser.Password = PasswordHasher.HashPassword(newUserDTO.Password, out salt);
            newUser.Salt = salt;
            newUser.Role = Roles.Customer;
            newUser = _unitOfWork.UserRepository.Create(newUser);
            _unitOfWork.SaveChanges();
            return newUser.Id;
        }
    }
}
