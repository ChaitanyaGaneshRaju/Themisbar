using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Errors;
using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
	public class AccountController : BaseAPIController
	{
		private readonly DataContext _context;
		public readonly ITokenService _tokenService;
		public AccountController(DataContext context, ITokenService tokenService)
		{
			this._tokenService = tokenService;
			this._context = context;
		}

		[HttpPost("login")]
		public async Task<ActionResult<UserTokenDto>> Login(LoginDto loginDto)
		{
			var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == loginDto.Email);

			if (user == null) return Unauthorized();

			using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
			{
				byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(loginDto.Password);
				byte[] hashBytes = md5.ComputeHash(inputBytes);

				// Convert the byte array to hexadecimal string
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					sb.Append(hashBytes[i].ToString("x2"));
				}
				var hashedPassword = sb.ToString();

				Console.Write(hashedPassword);
				Console.Write(user.Password);

				if (hashedPassword != user.Password)
				{
					return Unauthorized("Invalid Password");
				}

				return new UserTokenDto
				{
					Email = user.Email,
					Token = _tokenService.CreateToken(user)
				};
			}
		}
	}
}