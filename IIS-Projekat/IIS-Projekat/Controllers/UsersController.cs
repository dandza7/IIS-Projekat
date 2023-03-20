using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// [Admin] Gets all users
        /// </summary>
        /// <response code="200">Returns all users</response>
        [HttpPost(Name = "GetAllUsers")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<IEnumerable<PreviewUserDTO>> GetAllUsers([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_userService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Admin] Updates role of existing user
        /// </summary>
        /// <response code="200">If role is updated succesfully</response>
        /// <response code="400">If role is not valid</response>
        /// <response code="404">If user with sent id does not exists</response>
        /// <response code="451">If user with sent id is super admin</response>
        [HttpPost("role-update", Name = "UpdateRole")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult UpdateRole([FromBody] UpdateUsersRoleDTO updateUsersRoleDTO)
        {
            _userService.UpdateRole(updateUsersRoleDTO);
            return Ok();
        }
    }
}
