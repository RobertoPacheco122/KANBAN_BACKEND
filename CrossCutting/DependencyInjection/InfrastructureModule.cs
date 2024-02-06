using Domain.Interfaces.Repositories;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories;
using Infrastructure.Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrossCutting.DependencyInjection {
    public static class InfrastructureModule {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services) {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IBoardRepository, BoardImplementation>();
            services.AddScoped<ITaskRepository, TaskImplementation>();

            services.AddDbContext<DataContext>(
                options => options.UseNpgsql("Host=localhost;Port=5432;Database=kanbandddapi;Username=postgres;Password=fanta123")
            );

            return services;
        }
    }
}
