using IIS_Projekat.Models.DTOs.Food;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/food")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        /// <summary>
        /// [Nutritionist] Creates new Food
        /// </summary>
        /// <response code="200">If food is succesfully created, returns its ID</response>
        /// <response code="400">If category is not valid or food already exists!</response>
        /// <response code="404">If allergy with sent DI is not found!</response>
        [HttpPost("new", Name = "CreateFood")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<long> RegisterUser([FromBody] NewFoodDTO newFoodDTO)
        {
            return Ok(_foodService.Create(newFoodDTO));
        }

        /// <summary>
        /// [Nutritionist] Gets all food (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name, Category
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Name (string), Category (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all food</response>
        [HttpPost(Name = "GetAllFood")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<PaginationWrapper<PreviewUserDTO>> GetAllFood([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_foodService.GetAll(paginationQuery));
        }
    }
}
