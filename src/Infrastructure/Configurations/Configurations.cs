﻿using Bookstore.Application.Common.Interfaces;
using Bookstore.Infrastructure.Persistence;
using Bookstore.Infrastructure.Services;
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
            var conxString = configuration.GetConnectionString("ApiConnection");

            //adding dbcontext
            services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(conxString));

            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}