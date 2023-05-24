using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Therapy;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/therapy")]
    public class TherapyController: ControllerBase
    {
        private readonly ITherapyService _therapyService;

        public TherapyController(ITherapyService therapyService)
        {
            _therapyService = therapyService;
        }

        /// <summary>
        /// [Physiotherapist] Creates New Therapy
        /// </summary>
        /// <response code="200">If new therapy was addedd successfully</response>
        /// <response code="404">If muscle group does not exist</response>
        /// <response code="404">If patient does not exist</response>
        [HttpPost("create", Name = "TherapyCreation")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult<long> Create([FromBody] TherapyDTO therapy)
        {
            return Ok(_therapyService.Create(therapy));
        }

        /// <summary>
        /// [Physiotherapist] Gets all therapies (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// </remarks>
        /// <response code="200">Returns all therapies</response>
        [HttpPost(Name = "GetAllTherapies")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult<IEnumerable<PreviewTherapyDTO>> GetAll([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_therapyService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Physiotherapist] Get therapy by ID
        /// </summary>
        /// <response code="200">If therapy was found</response>
        /// <response code="404">If therapy was not found</response>
        [HttpGet("{id}", Name = "GetTherapyById")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult<PreviewTherapyDTO> GetById(long id)
        {
            return Ok(_therapyService.GetById(id));
        }

        /// <summary>
        /// [Physiotherapist] Deletes Therapy
        /// </summary>
        /// <response code="200">If therapy is successfully deleted</response>
        /// <response code="404">If therapy does not exist in the database</response>
        [HttpDelete("delete/{id}", Name = "DeleteTherapy")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult DeleteExercise(long id)
        {
            _therapyService.Delete(id);
            return Ok();
        }
    }
}
