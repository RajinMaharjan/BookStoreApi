using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Application.Common.Validator;
using Bookstore.Infrastructure.Persistence;
using Bookstore.Infrastructure.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Configurations
{
    public static class Configurations
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //fetching connection string
            //var conxString = configuration.GetConnectionString("ApiConnection");

            //adding dbcontext
            //services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(conxString));


            //fetching connection string
            var conxString = configuration.GetConnectionString("DbConnection");

            //adding dbcontext
            services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(conxString));

            //Adding database connection
            //var connectionString = configuration.GetConnectionString("DbConnection");

            // services.AddDbContext<BookStoreDbContext>(options =>
            // options.UseMySql(connectionString, MySqlServerVersion.LatestSupportedServerVersion), ServiceLifetime.Scoped);

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBookService, BookService>();

            //Adding Validators
            services.AddScoped<IValidator<UserRegisterRequestModel>, UserRegisterValidation>();
            services.AddScoped<IValidator<UserLoginRequestModel>, UserLoginValidation>();
            services.AddScoped<IValidator<UserUpdateRequestModel>, UserUpdateValidation>();


            return services;
        }
    }
}
