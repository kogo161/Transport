using System;
using System.Collections.Generic;
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

        // [HttpGet]
        // public UserResponse GetUser(int id)
        // {
        //     return _userService.GetUser(id);
        // }

        [HttpPost]
        public void AddUser(UserRequest request)
        {
            try
            {
                _userService.AddUser(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }

        [HttpGet]
        public List<UserResponse> GetUserWithTransport(int id)
        {
            try
            {
                return _userService.GetUserWithTransport(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}