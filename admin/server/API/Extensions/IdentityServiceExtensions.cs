using System.Text;
using Core.Entities;
using Core.Entities.Identity;
using Infrastructure.Data;
using Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace API.Extensions
{
	public static class IdentityServiceExtensions
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
		{
			// var serverVersion = new MySqlServerVersion(new Version(5, 7, 33));

			// // Replace 'YourDbContext' with the name of your own DbContext derived class.
			// services.AddDbContext<AppIdentityDbContext>(
			// 	dbContextOptions => dbContextOptions
			// 		.UseMySql(config.GetConnectionString("DefaultConnection"), serverVersion)
			// 		// The following three options help with debugging, but should
			// 		// be changed or removed for production.
			// 		.LogTo(Console.WriteLine, LogLevel.Information)
			// 		.EnableSensitiveDataLogging()
			// 		.EnableDetailedErrors(false)
			// );
			
			services.AddIdentityCore<AppUser>(options =>
			{
				// add Identity options here
				options.Password.RequiredLength = 8;
			})
			.AddEntityFrameworkStores<DataContext>()
			.AddSignInManager<SignInManager<AppUser>>();
			
			services.AddAuthentication(auth => 
			{
				auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options => 
			{
				options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					RequireExpirationTime = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is the key that will be used in encryption")),
					ValidateIssuerSigningKey = true 
				};
			});
			
			services.AddAuthorization();
			
			return services;
		}
	}
}