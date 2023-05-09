using IIS_Projekat.Models.DTOs.Exercise;
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
        /// <response code="400">If muscle group is not valid</response>
        [HttpPost("create", Name = "ExerciseCreation")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> CreateExercise([FromBody] NewExerciseDTO newExerciseDTO)
        {
            return Ok(_exerciseService.CreateExercise(newExerciseDTO));
        }
    }
}
