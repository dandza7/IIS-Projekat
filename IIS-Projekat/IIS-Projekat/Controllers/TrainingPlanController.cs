using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/training-plan")]
    public class TrainingPlanController: ControllerBase
    {
        private readonly ITrainingPlanService _trainingPlanService;

        public TrainingPlanController(ITrainingPlanService trainingPlanService)
        {
            _trainingPlanService = trainingPlanService;
        }

        /// <summary>
        /// [Customer] Creates New Training Plan Request
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="400">If training plan request for the plan is deleted</response>
        /// <response code="404">If client that requested the plan is now deleted</response>
        [HttpPost("create", Name = "CreateTrainingPlan")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> CreateTrainingPlan([FromBody] TrainingPlanDTO trainingPlanDTO)
        {
            return Ok(_trainingPlanService.CreateTrainingPlan(trainingPlanDTO));
        }
    }
}
