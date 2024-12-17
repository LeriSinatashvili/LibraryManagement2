using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Services.Abstractions;
using LibraryManagement.Service.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(RegisterUserCommand registerUserComman)
        {

            var userService = new UserService(new UserRepository());
            await userService.ExecuteRegisterUser(registerUserComman);

            return Ok();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteUser(DeleteUserCommand deleteUserComman)
        {

            var userService = new UserService(new UserRepository());
            await userService.ExecuteDeleteUser(deleteUserComman);

            return Ok();
        }
    }
}
