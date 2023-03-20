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

        [HttpPost("registration", Name = "RegisterUser")]
        [AllowAnonymous]
        public ActionResult<long> RegisterUser([FromBody] NewUserDTO newUserDTO)
        {
            return Ok(_userService.Register(newUserDTO));
        }

        [HttpPost("login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<LogInResponseDTO> Login([FromBody] UserCredentialsDTO userCredentialsDTO)
        {
            var token = _userService.Authenticate(userCredentialsDTO);
            return Ok(token);
        }
    }
}
