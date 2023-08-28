using IIS_Projekat.Models.DTOs.Exercise;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/email-validation")]
    public class EmailValidationController : ControllerBase
    {
        private readonly IEmailValidationService _emailValidationService;

        public EmailValidationController(IEmailValidationService emailValidationService)
        {
            _emailValidationService = emailValidationService;
        }

        /// <summary>
        /// [Customer] Creates new validation request
        /// </summary>
        /// <response code="200">If new validation request was addedd successfully</response>
        /// <response code="404">If user with given email does not exist in the database</response>
        /// <response code="400">If user is already subscribed with email</response>
        /// <response code="400">If user's profile does not have at least a name set up</response>
        [HttpPost("create", Name = "EmailValidationCreation")]
        [Authorize(Roles = $"{Roles.Customer}, {Roles.Trainer}")]
        public ActionResult<long> Create()
        {
            return Ok(_emailValidationService.Create(User.GetEmail()));
        }

        /// <summary>
        /// [Customer] Attempts to validate email
        /// </summary>
        /// <response code="200">If email was validated successfully</response>
        /// <response code="404">If user with given email does not exist in the database</response>
        /// <response code="404">If user did not create a validation request</response>
        /// <response code="400">If the code user provided was incorrect</response>
        [HttpPost("validate", Name = "EmailValidation")]
        [Authorize(Roles = $"{Roles.Customer}, {Roles.Trainer}")]
        public ActionResult<long> Validate([FromBody] long code)
        {
            _emailValidationService.Validate(User.GetEmail(), code);
            return Ok();
        }

        /// <summary>
        /// [Customer] Cancels email subscription
        /// </summary>
        /// <response code="200">If email was validated successfully</response>
        /// <response code="404">If user with given email does not exist in the database</response>
        /// <response code="404">If user did not create a validation request</response>
        /// <response code="400">If the code user provided was incorrect</response>
        [HttpDelete("cancel", Name = "EmailSubscriptionCancellation")]
        [Authorize(Roles = $"{Roles.Customer}, {Roles.Trainer}")]
        public ActionResult<long> CancelEmailSubscription()
        {
            _emailValidationService.CancelEmailSubscription(User.GetEmail());
            return Ok();
        }
    }
}
