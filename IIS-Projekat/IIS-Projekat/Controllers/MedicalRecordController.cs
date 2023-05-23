using IIS_Projekat.Models.DTOs.MedicalRecord;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Training.Plan;
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

        /// <summary>
        /// [Doctor] Gets all medical records (with pagination)
        /// </summary>
        /// <response code="200">Returns all medical records</response>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// </remarks>
        [HttpPost(Name = "GetAllMedicalRecords")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<IEnumerable<PreviewMedicalRecord>> GetAll([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_medicalRecordService.GetAll(paginationQuery));
        }

        /// <summary>
        /// [Doctor] Get Medical Record By Id 
        /// </summary>
        /// <response code="200">If medical record was found</response>
        /// <response code="404">If medical record was not found</response>
        [HttpGet("{id}", Name = "GetMedicalRecord")]
        [Authorize(Roles = Roles.Doctors)]
        public ActionResult<PreviewMedicalRecord> GetById(long id)
        {
            return Ok(_medicalRecordService.GetById(id));
        }
    }
}
