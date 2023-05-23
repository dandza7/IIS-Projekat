using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.UsersProfile;
using IIS_Projekat.Services;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        /// <summary>
        /// [Doctors] Gets all users profiles (with pagination, sorting and filtering optional)
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// <br/>  > Orders:
        /// <br/>  >>> OrderField must be one of the following: Name, Surname, User.Role, Gender, BirthDate, User.Email
        /// <br/>  >>> Ordering must be either ASC or DESC
        /// <br/>  > Filters:
        /// <br/>  >>> Property must be one of the following: Name (string), Surname (string), User.Role (string), Gender (string), BirthDate (date), User.Email (string)
        /// <br/>  >>> Connectings: 0 - AND, 1 - OR (filters will be applied as intersection for AND and will be applied as union for OR)
        /// <br/>  >>> FilterValues:
        /// <br/>  >>>>> FilterValue has to be able to be converted to correct type
        /// <br/>  >>>>> Operations: 0 - StringContains, 1 - StringEquals, 2 - NumberEquals, 3 - NumberLessThan, 4 - NumberGreaterThan
        /// </remarks>
        /// <response code="200">Returns all users</response>
        [HttpPost(Name = "GetAllUsersProfiles")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<PaginationWrapper<PreviewUsersProfileDTO>> GetAllUsersProfiles([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_patientService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Doctors] Previews patients detailed profile
        /// </summary>
        /// <response code="200">Returns profile of patient with sent id</response>
        /// <response code="404">If user with sent id does not exists in database</response>
        [HttpGet("{id}", Name = "GetPatientDetailed")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<PreviewPatientDetailedDTO> GetPatientDetailed(long id)
        {
            return Ok(_patientService.GetPatientDetailed(id));
        }
    }
}
