using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTO;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;
using API.Errors;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
	[Authorize]
	public class UsersController : BaseAPIController
	{
		private readonly IGenericRepository<User> _usersRepo;
		private readonly IGenericRepository<Learner> _learnersRepo;
		private readonly IMapper _mapper;

		public UsersController(IGenericRepository<User> usersRepo, IGenericRepository<Learner> learnersRepo, IMapper mapper)
		{
			_usersRepo = usersRepo;
			_learnersRepo = learnersRepo;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<User>>> GetUsers(string sort)
		{
			var spec = new UserSpecification(sort);
			return Ok(await _usersRepo.ListAsync(spec));
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(APIResponse), StatusCodes.Status404NotFound)]
		public async Task<ActionResult<UserLearnerDto>> GetUser(long id)
		{	
			var spec = new UserSpecification(id);
			var user = await _usersRepo.GetEntityWithSpec(spec);
			
			if (user == null) return NotFound(new APIResponse(404));
			
			return _mapper.Map<User, UserLearnerDto>(user);
		} 
		
	}
}