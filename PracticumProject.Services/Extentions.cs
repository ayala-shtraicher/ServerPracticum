using Microsoft.Extensions.DependencyInjection;
using PracticumProject.Context;
using PracticumProject.Repositories;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Services.Interfaces;
using PracticumProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddService(this IServiceCollection services) {
            services.AddRepository();
            services.AddSingleton<IContext, MyDbContext>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IChildUserService, ChildUserService>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
