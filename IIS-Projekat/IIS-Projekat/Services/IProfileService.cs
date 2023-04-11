using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.Services
{
    public interface IProfileService
    {
        public void UpdateUsersProfile(UpdateUsersProfileDTO updateUsersProfileDTO);
        public void UpdateOwnProfile(UpdateOwnProfileDTO updateOwnProfileDTO, string email);
        public void UpdateOwnAvatar(IFormFile avatar, string email);
        public void DeleteOwnAvatar(string email);
        public void DeleteUsersAvatar(long id);
        public byte[] PreviewOwnAvatar(string email);
        public byte[] PreviewUsersAvatar(long id);
        public PreviewUsersProfileDTO GetProfilePreview(long id);
        public PreviewUsersProfileDTO GetProfilePreview(string email);
    }
}
