using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.Services
{
    public interface IProfileService
    {
        public void UpdateUsersProfile(UpdateUsersProfileDTO updateUsersProfileDTO);
    }
}
