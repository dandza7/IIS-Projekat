using IIS_Projekat.Models.DTOs.NutritionPlan;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/nutritions")]
    public class NutritionController : ControllerBase
    {
        private readonly INutritionService _nutritionService;
        public NutritionController(INutritionService nutritionService)
        {
            _nutritionService = nutritionService;
        }

        /// <summary>
        /// [Nutritionist] Gets nutrition plan for sent user and date
        /// </summary>
        /// <response code="200">Returns nutrition plan with sent keys</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpPost(Name = "GetNutritionPlan")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult<ResponseNutritionPlanDTO> GetNutritionPlan([FromBody] NutritionPlanKeyDTO nutritionPlanKeyDTO)
        {
            return Ok(_nutritionService.GetOne(nutritionPlanKeyDTO));
        }

        /// <summary>
        /// [Nutritionist] Updates nutrition plan
        /// </summary>
        /// <response code="200">Returns nutrition plan with sent keys</response>
        /// <response code="404">If nutrition plan was not found</response>
        [HttpPost("update", Name = "UpdateNutritionPlan")]
        [Authorize(Roles = Roles.Nutritionist)]
        public ActionResult UpdateNutritionPlan([FromBody] NewNutritionPlanDTO newNutritionPlanDTO)
        {
            _nutritionService.Update(newNutritionPlanDTO);
            return Ok();
        }

        /// <summary>
        /// [Admin] Gets all nutrition plans that are not ordered
        /// </summary>
        /// <response code="200">Returns nutrition plans</response>
        [HttpGet("{page}", Name = "GetUnorderedNutritionPlans")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<PaginationWrapper<PreviewNutritionPlanDTO>> GetUnorderedNutritionPlans(int page = 1)
        {
            return Ok(_nutritionService.GetUnorderedNutritionPlans(page));
        }

        /// <summary>
        /// [Admin] Gets all nutrition plans without details
        /// </summary>
        /// <response code="200">Returns nutrition plans</response>
        [HttpGet("detailed/{id}", Name = "GetNutritionPlanWithIngredients")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<PreviewNutritionPlanContentDTO> GetNutritionPlanWithIngredients(long id)
        {
            return Ok(_nutritionService.GetNutritionPlanWithIngredients(id));
        }
    }
}
