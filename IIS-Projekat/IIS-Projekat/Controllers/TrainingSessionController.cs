using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/training-session")]
    public class TrainingSessionController: ControllerBase
    {
        private ITrainingSessionService _trainingSessionService;

        public TrainingSessionController(ITrainingSessionService trainingSessionService)
        {
            _trainingSessionService = trainingSessionService;
        }

        /// <summary>
        /// [Trainer] Creates New Training Session
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="404">If training plan for the session was not found</response>
        [HttpPost("create", Name = "CreateTrainingSession")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> CreateTrainingSession([FromBody] TrainingSessionDTO trainingSessionDTO)
        {
            return Ok(_trainingSessionService.CreateTrainingSession(trainingSessionDTO));
        }

        /// <summary>
        /// [Trainer] Adds an exercise to a training session
        /// </summary>
        /// <response code="200">If new training plan was added successfully</response>
        /// <response code="404">If exercse was not found</response>
        /// <response code="404">If training session for the exercse was not found</response>
        /// <response code="400">If repetition range is invalid</response>
        /// <response code="400">If number of sets is invalid</response>
        [HttpPost("add-exercise", Name = "AddExerciseToTrainingSession")]
        [Authorize(Roles = Roles.Trainer)]
        public ActionResult<long> AddExerciseToTrainingSession([FromBody] ExerciseTrainingSessionDTO exerciseTrainingSessionDTO)
        {
            return Ok(_trainingSessionService.AddExerciseToTrainingSession(exerciseTrainingSessionDTO));
        }
        
    }
}
