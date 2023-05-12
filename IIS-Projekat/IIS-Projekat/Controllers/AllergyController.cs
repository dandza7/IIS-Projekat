using IIS_Projekat.Models.DTOs.Allergy;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/allergies")]
    public class AllergyController : ControllerBase
    {
        private readonly IAllergyService _allergyService;
        public AllergyController(IAllergyService allergyService)
        {
            _allergyService = allergyService;
        }

        /// <summary>
        /// [Nutritionist] Gets all allergies (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Name (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all allergies</response>
        [HttpPost(Name = "GetAllAllergies")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<PaginationWrapper<PreviewUserDTO>> GetAllFood([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_allergyService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Nutritionist] Creates new Allergy
        /// </summary>
        /// <response code="200">If allergy is succesfully created, returns its ID</response>
        /// <response code="400">If alergy name is already taken!</response>
        [HttpPost("new", Name = "CreateAllergy")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<long> CreateAllergy([FromBody] NewAllergyDTO newAllergyDTO)
        {
            return Ok(_allergyService.Create(newAllergyDTO));
        }
    }
}
