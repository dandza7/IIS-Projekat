using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
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
        /// [Admin] Gets all users (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Email, Role
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Email (string), Role (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all users</response>
        [HttpPost(Name = "GetAllUsers")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<PaginationWrapper<PreviewUserDTO>> GetAllUsers([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_userService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Admin] Gets all trainers (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Email, Role
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Email (string), Role (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all trainers</response>
        [HttpPost("trainers", Name = "GetAllTrainers")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<PaginationWrapper<PreviewTrainerDTO>> GetAllTrainers([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_userService.GetAllTrainers(paginationQuery));
        }

        /// <summary>
        /// [Admin] Updates role of existing user
        /// </summary>
        /// <response code="200">If role is updated succesfully</response>
        /// <response code="400">If role is not valid</response>
        /// <response code="404">If user with sent id does not exists</response>
        /// <response code="451">If user with sent id is super admin</response>
        [HttpPost("role-update", Name = "UpdateRole")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult UpdateRole([FromBody] UpdateUsersRoleDTO updateUsersRoleDTO)
        {
            _userService.UpdateRole(updateUsersRoleDTO);
            return Ok();
        }
    }
}
