using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Plan;
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
        /// [Trainer] Creates New Training Plan
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="400">If training plan request for the plan is deleted</response>
        /// <response code="404">If client that requested the plan is now deleted</response>
        /// <response code="400">If there is duplicate training session name</response>
        /// <response code="404">If client profile was not found</response>
        [HttpPost("create", Name = "CreateTrainingPlan")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> CreateTrainingPlan([FromBody] TrainingPlanDTO trainingPlanDTO)
        {
            return Ok(_trainingPlanService.CreateTrainingPlan(trainingPlanDTO));
        }

        /// <summary>
        /// [Trainer] Updates Training Plan
        /// </summary>
        /// <response code="200">If new training plan was updated successfully</response>
        /// <response code="404">If client that requested the plan is now deleted</response>
        /// <response code="400">If there is duplicate training session name</response>
        /// <response code="404">If client profile was not found</response>
        [HttpPut("update", Name = "UpdateTrainingPlan")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> UpdateTrainingPlan([FromBody] UpdateTrainingPlanDTO updateTrainingPlanDTO)
        {
            return Ok(_trainingPlanService.UpdateTrainingPlan(updateTrainingPlanDTO));
        }

        /// <summary>
        /// [Trainer] Gets all training plans (with pagination)
        /// </summary>
        /// <response code="200">Returns all training plans</response>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// </remarks>
        [HttpPost(Name = "GetAllTrainingPlans")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<PreviewTrainingPlanDTO>> GetAll([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_trainingPlanService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Trainer] Get Detailed Training Plan
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="404">If training plan was not found</response>
        /// <response code="404">If client for training plan was not found</response>
        [HttpPost("detailedTrainingPlan/{planId}", Name = "GetDetailedTrainingPlan")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<PreviewDetailedTrainingPlanDTO> GetDetailedTrainingPlanForTrainer(long planId)
        {
            return Ok(_trainingPlanService.GetDetailedTrainingPlanForTrainer(planId));
        }

        /// <summary>
        /// [Customer] Gets customers Training Plan
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="404">If client for training plan was not found</response>
        /// <response code="404">If training plan was not found</response>
        [HttpPost("trainingPlanForClient", Name = "GetTrainnigPlanForClient")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<PreviewTrainingPlanForClient> GetTrainingPlanForClient(string email)
        {
            return Ok(_trainingPlanService.GetTrainingPlanForClient(email));
        }

    }
}
