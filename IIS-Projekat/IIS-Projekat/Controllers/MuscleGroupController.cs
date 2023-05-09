using IIS_Projekat.Models.DTOs.MuscleGroup;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/muscle-group")]
    public class MuscleGroupController : ControllerBase
    {
        private readonly IMuscleGroupService _muscleGroupService;

        public MuscleGroupController(IMuscleGroupService muscleGroupService)
        {
            _muscleGroupService = muscleGroupService;
        }

        /// <summary>
        /// [Trainer] Gets all msucle groups (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// </remarks>
        /// <response code="200">Returns all muscle groups</response>
        [HttpPost("get", Name = "GetAllMuscleGroups")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<MuscleGroupDTO>> GetAllMuscleGroups ([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_muscleGroupService.GetAll(paginationQuery));
        }
    }
}
