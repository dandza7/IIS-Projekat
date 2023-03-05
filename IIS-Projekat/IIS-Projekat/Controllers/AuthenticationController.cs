using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;
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
        public ActionResult<long> RegisterUser([FromBody] NewUserDTO newUserDTO)
        {
            var createdUserId = _userService.Register(newUserDTO);
            if (createdUserId == 0)
            {
                return BadRequest("User with this email already exists!");
            }
            return Ok(createdUserId);
        }
    }
}
