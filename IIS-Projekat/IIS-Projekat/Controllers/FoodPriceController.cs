using IIS_Projekat.Services;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/food-prices")]
    public class FoodPriceController : ControllerBase
    {
        private readonly IFoodPriceService _foodPriceService;
        public FoodPriceController(IFoodPriceService foodPriceService)
        {
            _foodPriceService = foodPriceService;
        }
    }
}
