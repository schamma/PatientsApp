using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.Data;
using PatientsApp.Server.Helpers;
using PatientsApp.Server.Interfaces;
using PatientsApp.Server.Services;

namespace PatientsApp.Server.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
              // Use connection string from file.
              var connStr = config.GetConnectionString("DefaultConnection");

              options.UseSqlite(connStr);
            });

            return services;
        }
    }
}
