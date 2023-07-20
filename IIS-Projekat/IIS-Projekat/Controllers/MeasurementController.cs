using IIS_Projekat.Models.DTOs.Measurement;
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
        /// [Trainer, Doctor, Customer] Gets Customers Measurements For Time Period
        /// </summary>
        /// /// <remarks>
        /// Timer period (filter) constraints:
        /// <br/>  > Values:
        /// <br/>  >>> "Monthly": measurements after or on the same day of previous month
        /// <br/>  >>> "Yearly": measurements after or on the same day of previous year
        /// <br/>  >>> Default: all time measurements
        /// </remarks>
        /// <response code="200">If measurements were retrieved successfully</response>
        /// <response code="404">If patient was not found</response>
        /// <response code="404">If patient's medical record was not found</response>
        [HttpPost("getMeasurements/{customerId}", Name = "GetCustomersMeasurements")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Doctors}, {Roles.Customer}")]
        public ActionResult<ICollection<PreviewMeasurementDTO>> GetCustomersMeasurements(long customerId, [FromBody] string filter)
        {
            return Ok(_measurementService.GetMeasurementsForPatient(customerId, filter));
        }
    }
}
