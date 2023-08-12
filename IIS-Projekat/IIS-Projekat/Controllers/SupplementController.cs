using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Supplement;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/supplement")]
    public class SupplementController: ControllerBase
    {
        private ISupplementService _supplementService;

        public SupplementController(ISupplementService supplementService)
        {
            _supplementService = supplementService;
        }

        /// <summary>
        /// [Nutritionist] Adds new supplement
        /// </summary>
        /// <response code="200">If new supplement was added successfully</response>
        [HttpPost("create", Name = "Create")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<long> Create([FromBody] NewSupplementDTO newSupplementDTO)
        {
            return Ok(_supplementService.Create(newSupplementDTO));
        }

        /// <summary>
        /// [Nutritionist] Updates existing supplement
        /// </summary>
        /// <response code="200">If new supplement was updated successfully</response>
        /// <response code="404">If supplement was not found</response>
        [HttpPut("update", Name = "Update")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<long> Update([FromBody] UpdateSupplementDTO updateSupplementDTO)
        {
            return Ok(_supplementService.Update(updateSupplementDTO));
        }

        /// <summary>
        /// [Nutritionist] Deletes supplement
        /// </summary>
        /// <response code="200">If new supplement was deleted successfully</response>
        /// <response code="404">If supplement was not found</response>
        [HttpDelete("delete/{supplementId}", Name = "Delete")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult Delete(long supplementId)
        {
            _supplementService.Delete(supplementId);
            return Ok();
        }

        /// <summary>
        /// [Nutritionist] Gets all supplements (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// </remarks>
        /// <response code="200">Returns all supplements</response>
        [HttpPost(Name = "GetAll")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<IEnumerable<PreviewSupplementDTO>> GetAllExercises([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_supplementService.GetAll(paginationQuery));
        }
    }
}
