using Microsoft.AspNetCore.Mvc;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Presentation.DTOs;

namespace MonitoPetsBackend.Presentation.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserResponseDTO>>> Get()
        {
            var users = await _userService.GetAllUsers();

            if (users is null)
            {
                return NotFound();
            }

            var usersResponse = users.Select(user => new UserResponseDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                IsActive = user.IsActive
            });

            return Ok(usersResponse);
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserRequestDTO user)
        {
            if (user is null)
            {
                return BadRequest();
            }

            var alterRows = await _userService.CreateUser(new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                IsActive = user.IsActive
            });

            if (alterRows == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
