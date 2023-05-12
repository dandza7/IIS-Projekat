using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Recipe;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        /// <summary>
        /// [Nutritionist, Customer] Gets all recipes (with pagination, sorting and filtering optional)
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
        /// <response code="200">Returns all food</response>
        [HttpPost(Name = "GetAllRecipes")]
        [Authorize(Roles = $"{Roles.Nutritionist}, {Roles.Customer}")]
        public ActionResult<PaginationWrapper<PreviewRecipeDTO>> GetAllRecipes([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_recipeService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Nutritionist] Creates new Recipe
        /// </summary>
        /// <response code="200">If recipe is succesfully created, returns its ID</response>
        /// <response code="400">If recipe already exists!</response>
        /// <response code="404">If food with sent ID is not found!</response>
        [HttpPost("new", Name = "CreateRecipe")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<long> CreateRecipe([FromBody] NewRecipeDTO newRecipeDTO)
        {
            return Ok(_recipeService.Create(newRecipeDTO));
        }

        /// <summary>
        /// [Nutritionist, Customer] Gets detailed Recipe
        /// </summary>
        /// <response code="200">Returns detailed recipe</response>
        /// <response code="404">If recipe with sent ID is not found!</response>
        [HttpGet("{id}", Name = "GetDetailedRecipe")]
        [Authorize(Roles = $"{Roles.Nutritionist}, {Roles.Customer}")]
        public ActionResult<PreviewRecipeDetailedDTO> GetDetailedRecipe(long id)
        {
            return Ok(_recipeService.GetDetailed(id));
        }
    }
}
