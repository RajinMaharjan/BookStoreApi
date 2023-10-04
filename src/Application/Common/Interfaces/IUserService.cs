using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> CreateUserAsync(UserRegisterRequestModel userRegisterRequestModel);
        Task<User> UpdateUserAsync(Guid id,UserUpdateRequestModel userUpdateRequestModel);
        Task<User> LoginUserAsync(UserLoginRequestModel userLoginRequestModel);
        Task<User> DeleteUserAsync(Guid id);
        string GenerateToken(User user);
        Task<User> ChangeRoleToAdmin(Guid id);
        
    }
}
