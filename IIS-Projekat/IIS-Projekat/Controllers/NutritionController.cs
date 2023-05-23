using IIS_Projekat.Services;
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
    }
}
