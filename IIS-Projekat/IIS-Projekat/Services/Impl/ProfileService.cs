using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.SupportClasses.JWToken;

namespace IIS_Projekat.Services.Impl
{
    public class ProfileService : IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJWTGenerator _jwtGenerator;

        public ProfileService(IUnitOfWork unitOfWork, IMapper mapper, IJWTGenerator jwtGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtGenerator = jwtGenerator;
        }

        public PreviewUsersProfileDTO GetProfilePreview(long id)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException("User with sent ID does not exists in database!");
            }
            return _mapper.Map<PreviewUsersProfileDTO>(user);
        }

        public PreviewUsersProfileDTO GetProfilePreview(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Email == email).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException("User with sent Email does not exists in database!");
            }
            return _mapper.Map<PreviewUsersProfileDTO>(user);
        }

        public void UpdateOwnProfile(UpdateOwnProfileDTO updateOwnProfileDTO, string email)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Email == email).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException("User with sent Email does not exists in database!");
            }
            if (user.Profile == null)
            {
                user.Profile = new UsersProfile();
                user.Profile.CreatedDate = DateTime.UtcNow;
            }
            user.Profile.ModifiedDate = DateTime.UtcNow;
            user.Profile.Name = updateOwnProfileDTO.Name;
            user.Profile.Surname = updateOwnProfileDTO.Surname;
            user.Profile.BirthDate = updateOwnProfileDTO.BirthDate;
            user.Profile.Gender = updateOwnProfileDTO.Gender;
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUsersProfile(UpdateUsersProfileDTO updateUsersProfileDTO)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Id == updateUsersProfileDTO.UserId).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException("User with sent ID does not exists in database!");
            }
            if (user.Profile == null)
            {
                user.Profile = new UsersProfile();
                user.Profile.CreatedDate = DateTime.UtcNow;
            }
            user.Profile.ModifiedDate = DateTime.UtcNow;
            user.Profile.Name = updateUsersProfileDTO.Name;
            user.Profile.Surname = updateUsersProfileDTO.Surname;
            user.Profile.BirthDate = updateUsersProfileDTO.BirthDate;
            user.Profile.Gender = updateUsersProfileDTO.Gender;
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.SaveChanges();
        }
    }
}
