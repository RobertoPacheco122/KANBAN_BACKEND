using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrossCutting.DependencyInjection {
    public static class ApplicationModule {
        public static IServiceCollection AddApplication (this IServiceCollection services) {
            services.AddServices();

            return services;
        }

        private static IServiceCollection AddServices (this IServiceCollection services) {
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IListService, ListService>();
            services.AddScoped<ISubtaskService, SubtaskService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<ITaskService, TaskService>();

            return services;
        }
    }
}
