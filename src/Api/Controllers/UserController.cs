using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Application.Common.Models.ResponseModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<UserListResponseModel>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();

            return Ok(new UserListResponseModel
            {
                Response = new Response {
                    StatusCode = 200,
                    Message = "User Fetched Successfully"
                },
                Users = users
            });

        }

        [HttpPost("register")]
        public async Task<ActionResult<Response>> CreateUser([FromBody]UserRegisterRequestModel userRegisterRequestModel)
        {
            await _userService.CreateUserAsync(userRegisterRequestModel);

            return new Response {
                StatusCode = 200,
                Message = "Registration Successful" 
            };
        }

    }
}
