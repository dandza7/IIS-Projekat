using IIS_Projekat.Models.DTOs.Measurement;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training;
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
    [Route("api/measurement")]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementService _measurementService;

        public MeasurementController(IMeasurementService measurementService)
        {
            _measurementService = measurementService;
        }

        /// <summary>
        /// [Patient] Creates New Measurement
        /// </summary>
        /// <response code="200">If new measurement was added successfully</response>
        /// <response code="404">If patient was not found</response>
        /// <response code="404">If patient's medical record was not found</response>
        [HttpPost("create", Name = "CreateMeasurement")]
        [Authorize(Roles = Roles.Customer)]
        public ActionResult<long> CreateMeasurement([FromBody] NewMeasurementDTO measurementDTO)
        {
            return Ok(_measurementService.CreateMeasurement(measurementDTO, User.GetEmail()));
        }

        /// <summary>
        /// [Trainer, Doctor, Customer] Gets Customers Statistics For Time Period
        /// </summary>
        /// /// <remarks>
        /// Send -1 as customerId if it's customer getting his own statistics
        /// <br/> Time period (filter) constraints:
        /// <br/>  > Values:
        /// <br/>  >>> "Month": statistics for the last 30 days
        /// <br/>  >>> "Year": statistics for the last 365 days
        /// <br/>  >>> Default: statistics for the last 10 years
        /// <br/> Other constraints:
        /// <br/>  > ExerciseName:
        /// <br/>  >>> "False": doesn't get any exercises
        /// <br/>  >>> Any other: statistics for the exercise with that name for time period
        /// <br/>  > Boolean values:
        /// <br/>  >>> true: gets that measurement for time period
        /// </remarks>
        /// <response code="200">If statistics were retrieved successfully</response>
        /// <response code="404">If patient was not found</response>
        /// <response code="404">If patient's medical record was not found</response>
        /// <response code="404">If patient's training plan was not found</response>
        [HttpPost("getStatistics/{customerId}", Name = "GetStatisticsForPatient")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Doctors}, {Roles.Customer}")]
        public ActionResult<PreviewStatisticsDTO> GetStatisticsForPatient(long customerId, [FromBody] StatisticsFilterDTO filter)
        {
            return Ok(_measurementService.GetStatisticsForPatient(customerId, User.GetEmail(), filter));
        }
    }
}
