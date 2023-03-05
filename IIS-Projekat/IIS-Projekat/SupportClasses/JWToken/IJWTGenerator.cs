using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.SupportClasses.JWToken
{
    public interface IJWTGenerator
    {
        LogInResponseDTO GenerateToken(User user);
    }
}
