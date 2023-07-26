using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.Services
{
    public interface IUserService
    {
        public PaginationWrapper<PreviewUserDTO> GetAll(PaginationQuery? paginationQuery);
        public PaginationWrapper<PreviewTrainerDTO> GetAllTrainers(PaginationQuery? paginationQuery);
        public long Register(NewUserDTO newUserDTO);
        public LogInResponseDTO Authenticate(UserCredentialsDTO userCredentialsDTO);
        public bool IsEmailAvailable(string email);
        public void UpdateRole(UpdateUsersRoleDTO updateUsersRoleDTO);
    }
}
