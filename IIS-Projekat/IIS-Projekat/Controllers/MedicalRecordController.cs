using IIS_Projekat.Models.DTOs.MedicalRecord;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/medical-record")]
    public class MedicalRecordController: ControllerBase
    {
        private readonly IMedicalRecordService _medicalRecordService;

        public MedicalRecordController(IMedicalRecordService medicalRecordService)
        {
            _medicalRecordService = medicalRecordService;
        }

        /// <summary>
        /// [Doctor] Creates New Medical Record
        /// </summary>
        /// <response code="200">If new medical record was created successfully</response>
        /// <response code="404">If patient was not found</response>
        [HttpPost("create", Name = "MedicalRecordCreation")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<long> CreateMedicalRecord([FromBody] MedicalRecordDTO newMedicalRecord)
        {
            return Ok(_medicalRecordService.Create(newMedicalRecord));
        }
    }
}
