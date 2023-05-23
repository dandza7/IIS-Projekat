using IIS_Projekat.Services;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{

    [ApiController]
    [Route("api/food-ordering")]
    public class FoodOrderingController : ControllerBase
    {
        private readonly IFoodOrderingService _foodOrderingService;
        public FoodOrderingController(IFoodOrderingService foodOrderingService)
        {
            _foodOrderingService = foodOrderingService;
        }
    }
}
