using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	public class BuggyController : BaseAPIController
	{
		private readonly DataContext _context;

		public BuggyController(DataContext context)
		{
			_context = context;
		}

		[HttpGet("notfound")]
		public ActionResult GetNotFoundRequest()
		{
			return NotFound(new APIResponse(404));
		}
		
		[HttpGet("servererror")]
		public ActionResult GetServerError()
		{
			var user = _context.Users.FindAsync(-1);
			
			var userToReturn = user.ToString();
			
			return Ok();
		}
		
		[HttpGet("badrequest")]
		public ActionResult GetBadRequest()
		{
			return BadRequest(new APIResponse(400));
		}
		
		
		[HttpGet("badRequest/{id}")]
		public ActionResult GetBadRequest(int id)
		{
			return BadRequest(new APIResponse(id));
		}
		
	}
}