using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/profiles")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        /// <summary>
        /// [Admin] Previews users profiles
        /// </summary>
        /// <response code="200">Returns profile of user with sent id</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpGet("{id}", Name = "GetUsersProfile")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<PreviewUsersProfileDTO> GetUsersProfile(long id)
        {
            return Ok(_profileService.GetProfilePreview(id));
        }

        /// <summary>
        /// [Admin, Customer] Previews own profile
        /// </summary>
        /// <response code="200">Returns profile of signed in user</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpGet(Name = "GetOwnProfile")]
        [Authorize(Roles = "ADMIN, CUSTOMER")]
        public ActionResult<PreviewUsersProfileDTO> GetOwnProfile()
        {
            return Ok(_profileService.GetProfilePreview(User.GetEmail()));
        }

        /// <summary>
        /// [Admin] Updates users profile
        /// </summary>
        /// <response code="200">If users profile is successfully updated</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpPatch("update", Name = "UpdateUsersProfile")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult UpdateUsersProfile([FromBody] UpdateUsersProfileDTO updateUsersProfileDTO)
        {
            _profileService.UpdateUsersProfile(updateUsersProfileDTO);
            return Ok();
        }

        /// <summary>
        /// [Admin, Customer] Updates own profile
        /// </summary>
        /// <response code="200">If profile is successfully updated</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpPatch("update/own", Name = "UpdateOwnProfile")]
        [Authorize(Roles = "ADMIN, CUSTOMER")]
        public ActionResult UpdateOwnProfile([FromBody] UpdateOwnProfileDTO updateOwnProfileDTO)
        {
            _profileService.UpdateOwnProfile(updateOwnProfileDTO, User.GetEmail());
            return Ok();
        }

        /// <summary>
        /// [Admin, Customer] Updates own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully updated</response>
        /// <response code="400">If file is not in valid format or too large</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpPatch("avatar/update", Name = "UpdateOwnAvatar")]
        [Authorize(Roles = "ADMIN, CUSTOMER")]
        public ActionResult UpdateOwnAvatar(IFormFile avatar)
        {
            if (!ImageValidator.IsValid(avatar))
            {
                return BadRequest("File must be size maximum 2MB and in extensions: jpg, jpeg, png or gif");
            }
            _profileService.UpdateOwnAvatar(avatar, User.GetEmail());
            return Ok();
        }

        /// <summary>
        /// [Admin, Customer] Previews own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully returned</response>
        /// <response code="204">If user does not have saved avatar</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpGet("avatar", Name = "PreviewOwnAvatar")]
        [Authorize(Roles = "ADMIN, CUSTOMER")]
        public ActionResult PreviewOwnAvatar()
        {
            return File(_profileService.PreviewOwnAvatar(User.GetEmail()), "image/*");
        }

        /// <summary>
        /// [Admin] Previews others users avatar
        /// </summary>
        /// <response code="200">If avatar is successfully returned</response>
        /// <response code="204">If user does not have saved avatar</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpGet("avatar/{id}", Name = "PreviewUsersAvatar")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult PreviewUsersAvatar(long id)
        {
            return File(_profileService.PreviewUsersAvatar(id), "image/*");
        }

        /// <summary>
        /// [Admin, Customer] Deletes own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully deleted</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpDelete("avatar/delete", Name = "DeleteOwnAvatar")]
        [Authorize(Roles = "ADMIN, CUSTOMER")]
        public ActionResult DeleteOwnAvatar()
        {
            _profileService.DeleteOwnAvatar(User.GetEmail());
            return Ok();
        }

        /// <summary>
        /// [Admin] Deletes others user avatar
        /// </summary>
        /// <response code="200">If avatar is successfully deleted</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpDelete("avatar/delete/{id}", Name = "DeletUsersAvatar")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult DeletUsersAvatar(long id)
        {
            _profileService.DeleteUsersAvatar(id);
            return Ok();
        }
    }
}
