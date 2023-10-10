using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Application.Common.Models.ResponseModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IValidator<UserRegisterRequestModel> _registerValidator;
        private readonly IValidator<UserLoginRequestModel> _loginValidator;
        private readonly IValidator<UserUpdateRequestModel> _updateValidator;

        public UsersController(
            IUserService userService,
            IValidator<UserRegisterRequestModel> registerValidator,
            IValidator<UserLoginRequestModel> loginValidator,
            IValidator<UserUpdateRequestModel> updateValidator
            )
        {
            _userService = userService;
            _registerValidator = registerValidator ?? throw new ArgumentNullException(nameof(registerValidator));
            _loginValidator = loginValidator ?? throw new ArgumentNullException(nameof(loginValidator));
            _updateValidator = updateValidator ?? throw new ArgumentNullException(nameof(updateValidator));
        }
        [HttpGet("getAllUsers")]
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
        [HttpGet("getUserById/{id}")]
        public async Task<IActionResult> GetuserById([FromRoute]Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(new UserResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = $"User fetched with id {id}"
                },
                User = user
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> CreateUser([FromBody]UserRegisterRequestModel userRegisterRequestModel)
        {
            await _registerValidator.ValidateAsync(userRegisterRequestModel, options => options.ThrowOnFailures()).ConfigureAwait(false);
            var user = await _userService.CreateUserAsync(userRegisterRequestModel);
            var token = _userService.GenerateToken(user);

            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Registration Successful",
                Token = token
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody]UserLoginRequestModel userLoginRequestModel)
        {
            await _loginValidator.ValidateAsync(userLoginRequestModel, options => options.ThrowOnFailures()).ConfigureAwait(false);
            var user = await _userService.LoginUserAsync(userLoginRequestModel);

            var token = _userService.GenerateToken(user);

            return Ok(new Response
            {
                StatusCode = 200,
                Message = "Login Successful",
                Token = token,
            });
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id,[FromForm]UserUpdateRequestModel userUpdateRequestModel)
        {
            await _updateValidator.ValidateAsync(userUpdateRequestModel, options => options.ThrowOnFailures()).ConfigureAwait(false);
            await _userService.UpdateUserAsync(id, userUpdateRequestModel);

            return Ok(new Response
            {
                StatusCode = 200,
                Message = "Updated Successfully"
            });
        }

        [HttpPost("changeUserToAdmin")]
        public async Task<IActionResult> ChangeRoleToAdmin(Guid id)
        {
            var user = await _userService.ChangeRoleToAdmin(id);
            return Ok(user);
        }

        [HttpDelete("deleteUser/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute]Guid id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok(new Response
            {
                StatusCode = 200,
                Message = $"User deleted with id {id}"
            });
        }

    }
}
