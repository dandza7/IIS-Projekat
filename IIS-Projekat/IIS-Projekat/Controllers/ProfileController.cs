using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Services;
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
        [HttpGet("/{id}", Name = "GetUsersProfile")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult GetUsersProfile(long id)
        {
            return Ok();
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
    }
}
