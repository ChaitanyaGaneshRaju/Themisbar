using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using API.Middleware;
using Microsoft.AspNetCore.Mvc;
using API.Errors;
using API.Extensions;
using Microsoft.AspNetCore.Identity;
using Core.Entities.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("CorsPolicy");
app.UseStatusCodePagesWithRedirects("/errors/{0}");

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
// var dbContext = services.GetRequiredService<DbContext>();
// var userManager = services.GetRequiredService<UserManager<AppUser>>();
// var logger = services.GetRequiredService<ILogger<Program>>();

// try
// {
// } catch (Exception ex)
// {
// 	logger.LogError(ex, "An error occured");
// }