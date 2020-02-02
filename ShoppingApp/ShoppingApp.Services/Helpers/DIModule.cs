using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingApp.DataAccess;
using ShoppingApp.DataAccess.Interfaces;
using ShoppingApp.DataAccess.Repositories;
using ShoppingApp.Domain.Models;
using ShoppingApp.Services.Interfaces;
using ShoppingApp.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Helpers
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, 
            string connectionString)
        {
            services.AddDbContext<ShoppingDbContext>
                (x => x.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<ShoppingDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
