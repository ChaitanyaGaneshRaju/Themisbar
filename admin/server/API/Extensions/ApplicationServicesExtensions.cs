using API.Errors;
using API.Services;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
	public static class ApplicationServicesExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
		{

			// Add services to the container.
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<ITokenService, TokenService>();
			
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			services.AddControllersWithViews()
				.AddNewtonsoftJson(options =>
				options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
			);


			var serverVersion = new MySqlServerVersion(new Version(5, 7, 33));

			// Replace 'YourDbContext' with the name of your own DbContext derived class.
			services.AddDbContext<DataContext>(
				dbContextOptions => dbContextOptions
					.UseMySql(config.GetConnectionString("DefaultConnection"), serverVersion)
					// The following three options help with debugging, but should
					// be changed or removed for production.
					.LogTo(s => System.Diagnostics.Debug.WriteLine(s), LogLevel.Information)
					.EnableSensitiveDataLogging()
					.EnableDetailedErrors(false)
			);


			services.Configure<ApiBehaviorOptions>(options =>
			{
				options.InvalidModelStateResponseFactory = actionContext =>
				{
					var errors = actionContext.ModelState
								.Where(e => e.Value.Errors.Count > 0)
								.SelectMany(x => x.Value.Errors)
								.Select(x => x.ErrorMessage).ToArray();
								
					var errorResponse = new APIValidationErrorResponse
					{
						Errors = errors
					};
					return new BadRequestObjectResult(errorResponse);
				};
			});
			
			services.AddCors(opt => 
			{
				opt.AddPolicy("CorsPolicy",policy =>
				{
					policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200");
				});
			});
			
			return services;
		}
	}
}