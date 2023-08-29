using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/exercise")]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        /// <summary>
        /// [Trainer] Creates New Exercise
        /// </summary>
        /// <response code="200">If new exercise was addedd successfully</response>
        /// <response code="400">If exercise with given name already exists</response>
        /// <response code="400">If muscle group is not valid</response>
        [HttpPost("create", Name = "ExerciseCreation")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> CreateExercise([FromBody] NewExerciseDTO newExerciseDTO)
        {
            return Ok(_exerciseService.CreateExercise(newExerciseDTO, User.GetEmail()));
        }

        /// <summary>
        /// [Trainer, Physiotherapist] Gets all exercises (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// </remarks>
        /// <response code="200">Returns all exercises</response>
        [HttpPost(Name = "GetAllExercises")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Physiotherapist}")]
        public ActionResult<IEnumerable<Models.DTOs.Exercise.PreviewExerciseDTO>> GetAllExercises([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_exerciseService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Physiotherapist] Gets rehabilitation exercises (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Name
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// </remarks>
        /// <response code="200">Returns all rehabilitation exercises</response>
        [HttpPost("rehabilitaional", Name = "GetAllRehabilitationExercises")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult<IEnumerable<Models.DTOs.Exercise.PreviewExerciseDTO>> GetAllRehabilitationExercises([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_exerciseService.GetRehabilitationExercises(paginationQuery));
        }

        /// <summary>
        /// [Trainer] Gets suitable Exercises for Client
        /// </summary>
        /// <remarks>
        /// Suitable exercises are found based on clients injuries:
        /// <br/> >If injury severity is low then hypertrophic exercises with primary muscle group injured will be filtered out
        /// <br/> >If injury severity is high then hypertrophic exercises with primary or secondary muscle group injured will be filtered out
        /// <br/> >Rehabilitation exercises are the ones recommended by the physiotherapist
        /// <br/>Filter:
        /// <br/> >Exercise nature is either "Hypertrophic", "Rehabilitation" (or any if neither is specified)
        /// <br/> >If you give a primary muscle group then only suitable hypertrophic exercises with given primary muscle group will be retrieved
        /// <br/> >If you give a secondary muscle group then only suitable hypertrophic exercises which target the given muscle secondarily will be retrieved
        /// <br/>If you want all the suitable exercises do not specify the filter fields.
        /// </remarks>
        /// <response code="200">If suitable exercises were returned successfully</response>
        /// <response code="404">If client does not have a medical record</response>
        [HttpPost("suitableForClient/{clientId}", Name = "GetSuitableExercisesForClient")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<PreviewExerciseDTO>> GetSuitableExercisesForClient(long clientId, [FromBody] ExerciseFilterQuery exerciseFilterDTO)
        {
            return Ok(_exerciseService.GetSuitableExercisesForClient(clientId, exerciseFilterDTO));
        }

        /// <summary>
        /// [Customer, Trainer] Gets all the prescribed exercises by plan for customer
        /// </summary>
        /// <remarks>
        /// Send -1 as customerId if its the customer getting his own prescribed exercises,
        /// <br/> send the cusomterId if its the trainer getting the exercises for a customer
        /// <br/> Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// </remarks>
        /// <response code="200">If prescribed exercises were retrieved successfully</response>
        /// <response code="404">If client was not found</response>
        /// <response code="404">If client's training plan was not found</response>
        [HttpPost("prescribed/{customerId}", Name = "GetPrescribedExercises")]
        [Authorize(Roles = $"{Roles.Customer}, {Roles.Trainer}")]
        public ActionResult<PreviewExerciseNameDTO> GetPrescribedExercises(long customerId, [FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_exerciseService.GetExercisesByPlan(paginationQuery, customerId, User.GetEmail()));
        }

        /// <summary>
        /// [Customer] Flags that customer is unhappy with the exercise
        /// </summary>
        /// <response code="200">If new exercise was flagged successfully</response>
        /// <response code="404">If client was not found</response>
        /// <response code="404">If client's training plan was not found</response>
        /// <response code="404">If client profile was not found</response>
        [HttpPost("flag", Name = "FlagExericse")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult FlagExercise([FromBody] FlagExerciseDTO flagExerciseDTO)
        {
            _exerciseService.FlagExercise(User.GetEmail(), flagExerciseDTO);
            return Ok();
        }

        /// <summary>
        /// [Trainer, Physiotherapist] Deletes Exercise
        /// </summary>
        /// <response code="200">If exercise is successfully deleted</response>
        /// <response code="400">If exercise is already deleted</response>
        /// <response code="404">If exercise does not exist in the database</response>
        [HttpDelete("delete/{id}", Name = "DeleteExercise")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Physiotherapist}")]
        public ActionResult DeleteExercise(long id)
        {
            _exerciseService.DeleteExercise(id);
            return Ok();
        }
    }
}
