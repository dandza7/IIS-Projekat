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
        public ActionResult<long> CreateExercise([FromBody] Models.DTOs.Exercise.NewExerciseDTO newExerciseDTO)
        {
            return Ok(_exerciseService.CreateExercise(newExerciseDTO));
        }

        /// <summary>
        /// [Trainer] Gets all exercises (with pagination, sorting and filtering optional)
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
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<Models.DTOs.Exercise.PreviewExerciseDTO>> GetAllExercises([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_exerciseService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Trainer] Gets suitable Exercises for Client
        /// </summary>
        /// <remarks>
        /// Suitable exercises are found based on clients injuries:
        /// <br/> >If injury severity is low then hypertrophic exercises with primary muscle group injured will be filtered out
        /// <br/> >If injury severity is high then hypertrophic exercises with primary or secondary muscle group injured will be filtered out
        /// <br/> >If injury severity is not high then rehabilitational exercises with primary muscle group not injured will be filtered out
        /// </remarks>
        /// <response code="200">If suitable exercises were returned successfully</response>
        /// <response code="404">If client does not have a medical record</response>
        [HttpPost("suitableForClient/{clientId}", Name = "GetSuitableExercisesForClient")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<IEnumerable<Models.DTOs.Exercise.PreviewExerciseDTO>> GetSuitableExercisesForClient(long clientId)
        {
            return Ok(_exerciseService.GetSuitableExercisesForClient(clientId));
        }

        /// <summary>
        /// [Trainer] Deletes Exercise
        /// </summary>
        /// <response code="200">If exercise is successfully deleted</response>
        /// <response code="400">If exercise is already deleted</response>
        /// <response code="404">If exercise does not exist in the database</response>
        [HttpDelete("delete/{id}", Name = "DeleteExercise")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult DeleteExercise(long id)
        {
            _exerciseService.DeleteExercise(id);
            return Ok();
        }
    }
}
