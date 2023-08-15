using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Core.DTO;
using Core.Entities;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	public class AccountController : BaseAPIController
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			this._signInManager = signInManager;
			this._userManager = userManager;
			
		}
		
		[HttpPost("login")]
		public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
		{
			var user = await _userManager.FindByEmailAsync(loginDto.Email);
			
			if(user == null) return Unauthorized(new APIResponse(401));
			
			var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
			
			if(!result.Succeeded) return Unauthorized(new APIResponse(401));
			
			return new UserDto
			{
				Email = user.Email,
				Token = "Token",
				Username = user.UserName
			};
		}
	}
}