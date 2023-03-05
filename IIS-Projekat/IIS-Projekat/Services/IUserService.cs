using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.Services
{
    public interface IUserService
    {
        public IEnumerable<PreviewUserDTO> GetAll();
        public long Register(NewUserDTO newUserDTO);
        public LogInResponseDTO Authenticate(UserCredentialsDTO userCredentialsDTO);
        public bool IsEmailAvailable(string email);
    }
}
