using IIS_Projekat.Models.DTOs;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<PreviewUserDTO> GetAll()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            var usersDTO = new List<PreviewUserDTO>();
            foreach (var user in users)
            {
                usersDTO.Add(new PreviewUserDTO(user.Id, user.Email, user.Password, user.Role));
            }
            return usersDTO;
        }
    }
}
