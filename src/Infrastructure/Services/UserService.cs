using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly BookStoreDbContext _dbContext;
        public UserService(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<User> CreateUserAsync(UserRegisterRequestModel userRegisterRequestModel)
        {
            try
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterRequestModel.Password);
                var user = new User() 
                {
                    Id = Guid.NewGuid(),                    
                    FirstName = userRegisterRequestModel.FirstName,
                    LastName = userRegisterRequestModel.LastName,
                    Email = userRegisterRequestModel.Email,
                    PasswordHash = passwordHash,
                    PhoneNumber = userRegisterRequestModel.PhoneNumber,
                    Role = Role.User,                
                };
                var userToAdd = await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();    
                if (userToAdd != null)
                {
                    return user;
                }
                throw new Exception("Failed to create user");
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<User> DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                var userList = await _dbContext
                    .Users
                    .Where(x => x.Role == Role.User)
                    .ToListAsync();

                if(userList.Count == 0)
                {
                    throw new Exception("User does not exist.");
                }
                return userList;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<User> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> LoginUserAsync(UserLoginRequestModel userLoginRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(Guid id, UserUpdateRequestModel userUpdateRequestModel)
        {
            throw new NotImplementedException();
        }
    }
}
