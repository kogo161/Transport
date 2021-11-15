using Microsoft.AspNetCore.Mvc;
using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;
using Transport.Domain.Services;

namespace Transport.App.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public UserResponse GetUser(int id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public void AddUser(UserRequest request)
        {
            _userService.AddUser(request);
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}