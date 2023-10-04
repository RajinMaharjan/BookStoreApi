using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UserService(BookStoreDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public async Task<User> CreateUserAsync(UserRegisterRequestModel userRegisterRequestModel)
        {
            try
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterRequestModel.Password);
                var user = new User() 
                {          
                    FirstName = userRegisterRequestModel.FirstName,
                    LastName = userRegisterRequestModel.LastName,
                    Email = userRegisterRequestModel.Email,
                    PasswordHash = passwordHash,
                    PhoneNumber = userRegisterRequestModel.PhoneNumber,       
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

        public async Task<User> DeleteUserAsync(Guid id)
        {  
            return await GetUserByIdAsync(id); 
            
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

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
                if(user == null)
                {
                    throw new Exception("User does not exist.");
                }
                return user;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public async Task<User> LoginUserAsync(UserLoginRequestModel userLoginRequestModel)
        {
            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Email == userLoginRequestModel.Email);
                if (user == null)
                {
                    throw new Exception("Incorrect Email Address");
                }
                if (!BCrypt.Net.BCrypt.Verify(userLoginRequestModel.Password, user.PasswordHash))
                {
                    throw new Exception("Incorrect Password");
                }
                return user;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> UpdateUserAsync(Guid id, UserUpdateRequestModel userUpdateRequestModel)
        {
            try
            {
                var user = await GetUserByIdAsync(id);

                if (user == null)
                {
                    throw new Exception("User Not Found");
                }
                user.FirstName = string.IsNullOrEmpty(userUpdateRequestModel.FirstName) ? user.FirstName : userUpdateRequestModel.FirstName;
                user.LastName = string.IsNullOrEmpty(userUpdateRequestModel.LastName) ? user.LastName : userUpdateRequestModel.LastName;
                user.Email = string.IsNullOrEmpty(userUpdateRequestModel.Email) ? user.Email : userUpdateRequestModel.Email;
                user.PhoneNumber = string.IsNullOrEmpty(userUpdateRequestModel.PhoneNumber) ? user.PhoneNumber : userUpdateRequestModel.PhoneNumber;
                user.PhotoUrl = string.IsNullOrEmpty(userUpdateRequestModel.PhotoUrl) ? user.PhotoUrl : userUpdateRequestModel.PhotoUrl;
                user.PasswordHash = string.IsNullOrEmpty(BCrypt.Net.BCrypt.HashPassword(userUpdateRequestModel.Password)) ? user.PasswordHash : BCrypt.Net.BCrypt.HashPassword(userUpdateRequestModel.Password);

                await _dbContext.SaveChangesAsync();

                return user;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GenerateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value!));
            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature);
            var expireTime = DateTime.Now.AddHours(1);
            var token = new JwtSecurityToken(claims:claims,expires:expireTime, signingCredentials:creds);
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = expireTime,
                Secure = true
            };
            return jwt;

        }

        public async Task<User> ChangeRoleToAdmin(Guid id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            user.Role = Role.Admin;
            await _dbContext.SaveChangesAsync();
            return user;
            
        }
    }
}
