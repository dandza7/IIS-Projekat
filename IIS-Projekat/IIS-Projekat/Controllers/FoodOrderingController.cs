﻿using IIS_Projekat.Models.DTOs.FoodSupplying;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// [Admin] Creates new food order
        /// </summary>
        /// <response code="200">If food order is succesfully created, returns its ID</response>
        /// <response code="404">If nutrition plan with sent ID is not found!</response>
        [HttpPost("new", Name = "CreateOrder")]
        [Authorize(Roles = Roles.Admin)]
        public ActionResult<FoodSupplyingReportDTO> CreateOrder([FromBody] NewFoodOrderDTO newFoodOrderDTO)
        {
            return Ok(_foodOrderingService.CreateOrder(newFoodOrderDTO));
        }
    }
}
