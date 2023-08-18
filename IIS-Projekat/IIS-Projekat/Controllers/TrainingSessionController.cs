using IIS_Projekat.Models.DTOs.Training;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
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
        /// [Customer] Gets information for page rendering
        /// </summary>
        /// <response code="200">If information was retrieved successfully</response>
        /// <response code="404">If user or his plan were not found</response>
        [HttpGet("display", Name = "GetDisplayInformation")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<ShouldDocumentNewTrainingSessionDTO> GetDisplayInformation()
        {
            return Ok(_trainingSessionService.ShouldDocumentNewSessionDTO(User.GetEmail()));
        }

        /// <summary>
        /// [Customer] Documents training session
        /// </summary>
        /// <response code="200">If training session was documented successfully</response>
        /// <response code="404">If user, his plan or an exercise were not found</response>
        [HttpPost(Name = "DocumentTrainingSession")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult DocumentTrainingSession([FromBody] NewDocumentedTrainingSessionDTO session)
        {
            _trainingSessionService.DocumentNewTrainingSession(User.GetEmail(), session);
            return Ok();
        }

    }
}
