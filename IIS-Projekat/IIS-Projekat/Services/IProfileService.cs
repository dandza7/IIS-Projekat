using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.Services
{
    public interface IProfileService
    {
        public void UpdateUsersProfile(UpdateUsersProfileDTO updateUsersProfileDTO);
        public void UpdateOwnProfile(UpdateOwnProfileDTO updateOwnProfileDTO, string email);
        public PreviewUsersProfileDTO GetProfilePreview(long id);
        public PreviewUsersProfileDTO GetProfilePreview(string email);
    }
}
