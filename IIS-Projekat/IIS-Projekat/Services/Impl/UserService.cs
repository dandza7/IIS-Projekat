using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using IIS_Projekat.SupportClasses.JWToken;
using IIS_Projekat.SupportClasses.PasswordHasher;
using IIS_Projekat.SupportClasses.Roles;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IIS_Projekat.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJWTGenerator _jwtGenerator;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IJWTGenerator jwtGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtGenerator = jwtGenerator;
        }

        public PaginationWrapper<PreviewUserDTO> GetAll(PaginationQuery? paginationQuery)
        {

            var paginationResult = _unitOfWork.UserRepository.Filter(paginationQuery);

            return new PaginationWrapper<PreviewUserDTO>(_mapper.Map<List<PreviewUserDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public PaginationWrapper<PreviewTrainerDTO> GetAllTrainers(PaginationQuery? paginationQuery)
        {

            var trainers = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Role == "Trainer").ToList();
            ICollection<PreviewTrainerDTO> trainerDTOs = new List<PreviewTrainerDTO>();
            foreach (var trainer in trainers)
            {
                string biography = (trainer.Profile.Biography == "") ? "Trainer does not have a biography" : trainer.Profile.Biography;
                string fullName = (trainer.Profile.Name == null) ? "Trainer did not set up his profile." : trainer.Profile.Name;
                PreviewTrainerDTO trainerDTO = new PreviewTrainerDTO
                {
                    FullName = fullName,
                    Email = trainer.Email,
                    Biography = biography,
                    NumberOfClients = _unitOfWork.TrainingPlanRepository.GetAll().Where(tp => tp.Trainer == trainer).Count()
                };
                trainerDTOs.Add(trainerDTO);
            }
            return new PaginationWrapper<PreviewTrainerDTO>(
                _mapper.Map<List<PreviewTrainerDTO>>(trainerDTOs.Skip((paginationQuery.Page - 1) * paginationQuery.PageSize).Take(paginationQuery.PageSize)),
                trainerDTOs.Count
            );
        }

        public long Register(NewUserDTO newUserDTO)
        {
            var newUser = new User();
            newUser.Profile = new UsersProfile();
            newUser.Profile.CreatedDate = DateTime.UtcNow;
            newUser.Profile.ModifiedDate = DateTime.UtcNow;
            newUser.Email = newUserDTO.Email;
            byte[] salt;
            newUser.Password = PasswordHasher.HashPassword(newUserDTO.Password, out salt);
            newUser.Salt = salt;
            newUser.Role = Roles.Customer;
            newUser = _unitOfWork.UserRepository.Create(newUser);
            _unitOfWork.SaveChanges();
            return newUser.Id;
        }

        public LogInResponseDTO Authenticate(UserCredentialsDTO userCredentialsDTO)
        {
            User? user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == userCredentialsDTO.Email);
            if (user == null)
            {
                throw new NotFoundException($"User with email: {userCredentialsDTO.Email} does not exists!");
            }
            if (PasswordHasher.VerifyPassword(userCredentialsDTO.Password, user.Password, user.Salt))
            {
                return _jwtGenerator.GenerateToken(user);
            }
            throw new BadCredentialsException();
        }

        public bool IsEmailAvailable(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == email);
            return user == null;
        }

        public void UpdateRole(UpdateUsersRoleDTO updateUsersRoleDTO)
        {
            var user = _unitOfWork.UserRepository.GetById(updateUsersRoleDTO.Id);
            if (user == null)
            {
                throw new NotFoundException($"User with sent ID {updateUsersRoleDTO.Id} does not exist!");
            }
            if (user.Id == 1)
            {
                throw new RestrictedContentException("Super admin is not allowed to be changed!");
            }
            user.Role = updateUsersRoleDTO.Role;
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.SaveChanges();
        }
    }
}
