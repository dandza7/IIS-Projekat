using IIS_Projekat.Models.DTOs;

namespace IIS_Projekat.Services
{
    public interface IUserService
    {
        public IEnumerable<PreviewUserDTO> GetAll();
    }
}
