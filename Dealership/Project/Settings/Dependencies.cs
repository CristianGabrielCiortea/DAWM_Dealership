using Core.Services;
using DataLayer;
using DataLayer.Repositories;
using System;

namespace Project.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<CarService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<CarRepository>();
        }
    }
}
