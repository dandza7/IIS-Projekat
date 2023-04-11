using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Extensions;
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
        /// [Admin, Customer] Previews own profiles
        /// </summary>
        /// <response code="200">Returns profile of signed in user</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpGet("", Name = "GetOwnProfile")]
        [Authorize(Roles = "ADMIN")]
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
    }
}
