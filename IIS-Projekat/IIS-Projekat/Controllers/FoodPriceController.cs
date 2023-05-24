using IIS_Projekat.Models.DTOs.FoodPrice;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// [Admin] Get all food prices
        /// </summary>
        /// <response code="200">Returns all food prices</response>
        [HttpGet("{page}", Name = "GetAllFoodPrices")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<PaginationWrapper<PreviewFoodPricesDTO>> GetAllFoodPrices(int page = 1)
        {
            return Ok(_foodPriceService.GetAll(page));
        }

        /// <summary>
        /// [Admin] Add new food price
        /// </summary>
        /// <response code="200">Returns id of updated or new food price</response>
        /// <response code="404">If food with sent id does not exists</response>
        [HttpPost(Name = "AddNewFoodPrice")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<long> AddNewFoodPrice([FromBody] NewFoodPriceDTO newFoodPriceDTO)
        {
            return Ok(_foodPriceService.CreateOrUpdate(newFoodPriceDTO));
        }

        /// <summary>
        /// [Admin] Deletes food price
        /// </summary>
        /// <response code="200">Delete food price</response>
        /// <response code="404">If food price with sent id does not exists</response>
        [HttpDelete("{id}", Name = "DeleteFoodPrice")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult DeleteFoodPrice(long id)
        {
            _foodPriceService.Delete(id);
            return Ok();
        }
    }

}
