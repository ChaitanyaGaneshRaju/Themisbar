using Infrastructure.Data.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
		{
			var serverVersion = new MySqlServerVersion(new Version(5, 7, 33));

			// Replace 'YourDbContext' with the name of your own DbContext derived class.
			services.AddDbContext<AppIdentityDbContext>(
				dbContextOptions => dbContextOptions
					.UseMySql(config.GetConnectionString("DefaultConnection"), serverVersion)
					// The following three options help with debugging, but should
					// be changed or removed for production.
					.LogTo(Console.WriteLine, LogLevel.Information)
					.EnableSensitiveDataLogging()
					.EnableDetailedErrors(false)
			);
			return services;
		}
	}
}