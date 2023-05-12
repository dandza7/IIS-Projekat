using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
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
        /// [Doctors] Gets all users profiles (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: Name, Surname, User.Role, Gender, BirthDate, User.Email
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: Name (string), Surname (string), User.Role (string), Gender (string), BirthDate (date), User.Email (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all users</response>
        [HttpPost(Name = "GetAllUsersProfiles")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<PaginationWrapper<PreviewUserDTO>> GetAllUsersProfiles([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_profileService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Admin] Previews users profiles
        /// </summary>
        /// <response code="200">Returns profile of user with sent id</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpGet("{id}", Name = "GetUsersProfile")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<PreviewUsersProfileDTO> GetUsersProfile(long id)
        {
            return Ok(_profileService.GetProfilePreview(id));
        }

        /// <summary>
        /// [Authenticated] Previews own profile
        /// </summary>
        /// <response code="200">Returns profile of signed in user</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpGet(Name = "GetOwnProfile")]
        [Authorize(Roles = Roles.AvailableRoles)]
        public ActionResult<PreviewUsersProfileDTO> GetOwnProfile()
        {
            return Ok(_profileService.GetProfilePreview(User.GetEmail()));
        }

        /// <summary>
        /// [Admin] Updates users profile
        /// </summary>
        /// <response code="200">If users profile is successfully updated</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpPut("update", Name = "UpdateUsersProfile")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult UpdateUsersProfile([FromBody] UpdateUsersProfileDTO updateUsersProfileDTO)
        {
            _profileService.UpdateUsersProfile(updateUsersProfileDTO);
            return Ok();
        }

        /// <summary>
        /// [Authenticated] Updates own profile
        /// </summary>
        /// <response code="200">If profile is successfully updated</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpPut("update/own", Name = "UpdateOwnProfile")]
        [Authorize(Roles = Roles.AvailableRoles)]
        public ActionResult UpdateOwnProfile([FromBody] UpdateOwnProfileDTO updateOwnProfileDTO)
        {
            _profileService.UpdateOwnProfile(updateOwnProfileDTO, User.GetEmail());
            return Ok();
        }

        /// <summary>
        /// [Authenticated] Updates own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully updated</response>
        /// <response code="400">If file is not in valid format or too large</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpPatch("avatar/update", Name = "UpdateOwnAvatar")]
        [Authorize(Roles = Roles.AvailableRoles)]
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
        /// [Authenticated] Previews own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully returned</response>
        /// <response code="204">If user does not have saved avatar</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpGet("avatar", Name = "PreviewOwnAvatar")]
        [Authorize(Roles = Roles.AvailableRoles)]
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
        [Authorize(Roles = Roles.Admin)]
        public ActionResult PreviewUsersAvatar(long id)
        {
            return File(_profileService.PreviewUsersAvatar(id), "image/*");
        }

        /// <summary>
        /// [Authenticated] Deletes own avatar
        /// </summary>
        /// <response code="200">If avatar is successfully deleted</response>
        /// <response code="404">If user with email sent inside JWToken does not exist in database anymore</response>
        [HttpDelete("avatar/delete", Name = "DeleteOwnAvatar")]
        [Authorize(Roles = Roles.AvailableRoles)]
        public ActionResult DeleteOwnAvatar()
        {
            _profileService.DeleteOwnAvatar(User.GetEmail());
            return Ok();
        }

        /// <summary>
        /// [Authenticated] Deletes others user avatar
        /// </summary>
        /// <response code="200">If avatar is successfully deleted</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpDelete("avatar/delete/{id}", Name = "DeletUsersAvatar")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult DeletUsersAvatar(long id)
        {
            _profileService.DeleteUsersAvatar(id);
            return Ok();
        }
    }
}
