﻿using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Plan;
using IIS_Projekat.Models.DTOs.Training.Request;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/training-plan-request")]
    public class TrainingRequestController : ControllerBase
    {
        private readonly ITrainingPlanRequestService _trainingPlanRequestService;

        public TrainingRequestController(ITrainingPlanRequestService trainingPlanRequestService)
        {
            _trainingPlanRequestService = trainingPlanRequestService;
        }

        /// <summary>
        /// [Trainer] Gets all the pending training plan requests for trainer (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: CreatedDate, SessionsPerWeek, TrainingGoal
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: SessionsPerWeek (int), TrainingGoal (string), User.Profile.Name (string),
        /// <br/>  >>> User.Profile.Surname (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all pending training plan requests</response>
        [HttpPost("trainer", Name = "GetTrainingPlanRequestsForTrainer")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<PreviewTrainingPlanRequestDTO>> GetATrainingPlanRequests([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_trainingPlanRequestService.GetAllForTrainer(paginationQuery, User.GetEmail()));
        }

        /// <summary>
        /// [Customer] Creates New Training Plan Request
        /// </summary>
        /// <response code="200">If new training plan was requested successfully</response>
        /// <response code="400">If number of sessions per week is not between 2 and 6 inclusively</response>
        /// <response code="400">If training goal is not valid</response>
        /// <response code="400">If user has already created a training plan request</response>
        /// <response code="404">If client that requested the plan is now deleted</response>
        /// <response code="404">If client profile, medical record, or trainer were not found</response>
        [HttpPost("create", Name = "CreateTrainingPlanRequest")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<long> CreateTrainingPlanRequest([FromBody] TrainingPlanRequestDTO trainingPlanRequestDTO)
        {
            return Ok(_trainingPlanRequestService.CreateTrainingPlanRequest(trainingPlanRequestDTO, User.GetEmail()));
        }

        /// <summary>
        /// [Trainer] Get Training Plan Request
        /// </summary>
        /// <response code="200">If getting training plan request was successful</response>
        /// <response code="404">If training plan request was not found</response>
        [HttpGet("{id}", Name = "GetTrainingPlanRequest")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<PreviewDetailedTrainingPlanDTO> GetById(long id)
        {
            return Ok(_trainingPlanRequestService.GetById(id));
        }

        /// <summary>
        /// [Client] Deletes Training Plan Request
        /// </summary>
        /// <response code="200">If request is successfully deleted</response>
        /// <response code="404">If request does not exist in the database</response>
        [HttpDelete("delete/{id}", Name = "DeleteTrainingPlanRequest")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult DeleteExercise(long id)
        {
            _trainingPlanRequestService.DeleteTrainingPlanRequest(id);
            return Ok();
        }
    }
}
