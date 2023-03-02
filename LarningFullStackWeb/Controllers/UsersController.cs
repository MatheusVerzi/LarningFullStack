using LarningFullStackApplication.Interfaces;
using LarningFullStackApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LarningFullStackWeb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.userService.Get());
        }

        [HttpPost]
        public IActionResult Post(UserViewModel userViewModel)
        {
            return Ok(this.userService.Post(userViewModel));
        }
    }
}
