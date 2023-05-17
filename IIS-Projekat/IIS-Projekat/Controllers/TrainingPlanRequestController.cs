using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Services;
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
        /// [Trainer] Gets all the pending training plan requests (with pagination, sorting and filtering optional)
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
        [HttpPost(Name = "GetAll")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<PreviewTrainingPlanRequestDTO>> GetAllTrainingPlanRequests([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_trainingPlanRequestService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Customer] Creates New Training Plan Request
        /// </summary>
        /// <response code="200">If new training plan was requested successfully</response>
        /// <response code="400">If number of sessions per week is not between 2 and 6 inclusively</response>
        /// <response code="400">If training goal is not valid</response>
        /// <response code="400">If user has already created a training plan request</response>
        /// <response code="404">If client that requested the plan is now deleted</response>
        [HttpPost("create", Name = "CreateTrainingPlanRequest")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<long> CreateTrainingPlanRequest([FromBody] TrainingPlanRequestDTO trainingPlanRequestDTO)
        {
            return Ok(_trainingPlanRequestService.CreateTrainingPlanRequest(trainingPlanRequestDTO, User.GetEmail()));
        }
    }
}
