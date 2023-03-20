using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// [Anonymous] Registers new user
        /// </summary>
        /// <response code="200">If user is succesfully registered, returns its ID</response>
        /// <response code="400">If credentials did not pass the validation</response>
        [HttpPost("registration", Name = "RegisterUser")]
        [AllowAnonymous]
        public ActionResult<long> RegisterUser([FromBody] NewUserDTO newUserDTO)
        {
            return Ok(_userService.Register(newUserDTO));
        }

        /// <summary>
        /// [Anonymous] Authenticates user
        /// </summary>
        /// <response code="200">Returns JWToken and its expiration date</response>
        /// <response code="400">If credentials do not match</response>
        /// <response code="404">If email does not exists in database</response>
        [HttpPost("login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<LogInResponseDTO> Login([FromBody] UserCredentialsDTO userCredentialsDTO)
        {
            var token = _userService.Authenticate(userCredentialsDTO);
            return Ok(token);
        }
    }
}
