using IIS_Projekat.Models.DTOs;
using IIS_Projekat.Services;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet(Name = "GetAllUsers")]
        public ActionResult<IEnumerable<PreviewUserDTO>> GetAllUsers()
        {
            return Ok(_userService.GetAll());
        }
    }
}
