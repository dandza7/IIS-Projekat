using IIS_Projekat.Models.DTOs.Therapy;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/therapy")]
    public class TherapyController: ControllerBase
    {
        private readonly ITherapyService _therapyService;

        public TherapyController(ITherapyService therapyService)
        {
            _therapyService = therapyService;
        }

        /// <summary>
        /// [Physiotherapist] Creates New Therapy
        /// </summary>
        /// <response code="200">If new therapy was addedd successfully</response>
        /// <response code="404">If muscle group does not exist</response>
        /// <response code="404">If patient does not exist</response>
        [HttpPost("create", Name = "TherapyCreation")]
        [Authorize(Roles = Roles.Physiotherapist)]
        public ActionResult<long> Create([FromBody] TherapyDTO therapy)
        {
            return Ok(_therapyService.Create(therapy));
        }
    }
}
