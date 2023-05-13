using IIS_Projekat.Models.DTOs.Appointment;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        /// <summary>
        /// [Customer, Physiotherapist] Gets all appointments (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: ID, Beginning, Ending, Doctor.Email, Patient.Email
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: ID (number), Beginning (string), Ending (string), Doctor.Email (string), Patient.Email (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all users</response>
        [HttpPost(Name = "GetAllAppointments")]
        [Authorize(Roles = $"{Roles.Customer}, {Roles.Physiotherapist}")]
        public ActionResult<PaginationWrapper<PreviewUserDTO>> GetAllUsers([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_appointmentService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Doctors] Creates new Appointment
        /// </summary>
        /// <response code="200">If allergy is succesfully created, returns its ID</response>
        /// <response code="400">If alergy name is already taken!</response>
        [HttpPost("new", Name = "CreateDoctor")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<long> CreateDoctor([FromBody] NewAppointmentByDoctorDTO newAppointment)
        {
            return Ok(_appointmentService.Create(newAppointment, User.GetEmail()));
        }
    }
}
