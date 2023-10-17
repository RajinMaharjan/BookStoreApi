using Bookstore.Application.Common.Exceptions;
using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _env;
        private readonly string _imageProductDirectory;

        public UserService(BookStoreDbContext dbContext, IConfiguration configuration, IWebHostEnvironment env)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _env = env ?? throw new ArgumentNullException(nameof(env));
            _imageProductDirectory = env.WebRootPath + @"\Images\Users";
        }
        public async Task<User> CreateUserAsync(UserRegisterRequestModel userRegisterRequestModel)
        {
            try
            {
                var userExist = await _dbContext.Users.FirstOrDefaultAsync(x=> x.Email == userRegisterRequestModel.Email);
                if (userExist != null)
                {
                    throw new PersistenceException("Email already registered");
                }
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
                throw new PersistenceException("Failed to create user");
                
            }
            catch (PersistenceException ex)
            {
                throw new PersistenceException(ex.Message);
            }
        }

        public async Task<User> DeleteUserAsync(Guid id)
        {
            try
            {
                var user = await GetUserByIdAsync(id);
                user.IsDeleted = true;
                await _dbContext.SaveChangesAsync();
                return user;

            }catch(PersistenceException ex)
            {
                throw new PersistenceException(ex.Message);
            }
            
        }

      

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                var userList = await _dbContext
                    .Users
                    .Where(x => x.Role == Role.User && x.IsDeleted == false)
                    .OrderBy(x => x.FirstName)
                    .ToListAsync();

                if(userList.Count == 0)
                {
                    throw new EntityNotFoundException("User does not exist.");
                }
                return userList;
            }
            catch(EntityNotFoundException ex)
            {
                throw new EntityNotFoundException(ex.Message);
            }
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
                if(user == null)
                {
                    throw new EntityNotFoundException("User does not exist.");
                }
                return user;

            }catch(EntityNotFoundException ex)
            {
                throw new EntityNotFoundException(ex.Message);
            }
           
        }

        public async Task<User> LoginUserAsync(UserLoginRequestModel userLoginRequestModel)
        {
            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Email == userLoginRequestModel.Email);
                if (user == null)
                {
                    throw new PersistenceException("Incorrect Email Address");
                }
                if (!BCrypt.Net.BCrypt.Verify(userLoginRequestModel.Password, user.PasswordHash))
                {
                    throw new PersistenceException("Incorrect Password");
                }
                return user;
            }catch(PersistenceException ex)
            {
                throw new PersistenceException(ex.Message);
            }
        }

        public async Task<User> UpdateUserAsync(Guid id, UserUpdateRequestModel userUpdateRequestModel)
        {
            try
            {
                var user = await GetUserByIdAsync(id);

                if (user == null)
                {
                    throw new EntityNotFoundException("User Not Found");
                }

                

                user.FirstName = string.IsNullOrEmpty(userUpdateRequestModel.FirstName) ? user.FirstName : userUpdateRequestModel.FirstName;
                user.LastName = string.IsNullOrEmpty(userUpdateRequestModel.LastName) ? user.LastName : userUpdateRequestModel.LastName;
               
                if(userUpdateRequestModel.Image != null)
                {
                    if (!Directory.Exists(_imageProductDirectory))
                    {
                        Directory.CreateDirectory(_imageProductDirectory);
                    }
                    FileInfo _fileInfo = new FileInfo(userUpdateRequestModel.Image!.FileName);
                    string filename = _fileInfo.Name.Replace(_fileInfo.Extension, "") + "_" + DateTime.Now.Ticks.ToString() + _fileInfo.Extension;
                    var _filePath = $"{_imageProductDirectory}\\{filename}";

                    using (var _fileStream = new FileStream(_filePath, FileMode.Create))
                    {
                        await userUpdateRequestModel.Image.CopyToAsync(_fileStream);
                    }
                    string _urlPath = _filePath.Replace('\\', '/').Split("wwwroot").Last();
                    string _imagePath = _filePath.Split("wwwroot").Last();
                    user.ImagePath =  _imagePath;
                    user.ImageUrl = _urlPath;
                }
                user.ImagePath = user.ImagePath;
                user.ImageUrl = user.ImageUrl;
                

                await _dbContext.SaveChangesAsync();

                return user;    
            }

            catch(EntityNotFoundException ex)
            {
                throw new EntityNotFoundException(ex.Message);
            }
        }

        public string GenerateToken(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value!);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new []
                {
                    new Claim("Id", user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name, user.FirstName!),
                    new Claim("LastName",user.LastName!),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email!),
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                    new Claim("PhoneNumber",user.PhoneNumber!),

                }),
                Expires = DateTime.UtcNow.AddHours(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);            

            CookieOptions cookieOptions = new CookieOptions()
            {
                Secure = true
            };
            return jwtToken;

        }

        public async Task<User> ChangeRoleToAdmin(Guid id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            user!.Role = Role.Admin;
            await _dbContext.SaveChangesAsync();
            return user;
            
        }

        
    }
}
