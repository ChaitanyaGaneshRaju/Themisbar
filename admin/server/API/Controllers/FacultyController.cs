using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DAO;
using Core.DTO;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Authorize]
	public class FacultyController : BaseAPIController
	{
		public FacultyController()
		{
		}

		[HttpGet("GetCourses/{facultyId}")] 
		public async Task<ActionResult<List<CourseIdNameDto>>> GetCourses(long facultyId)
		{
			FacultyDao fd = new();
			List<CourseIdNameDto> courses = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyCourses(facultyId));

			return Ok(courses);
		}
		
		
		[HttpGet("GetLawSchools/{IdUser}")] 
		public async Task<ActionResult<IReadOnlyList<FacultyLawSchool>>> GetLawSchools(long IdUser)
		{
			FacultyDao fd = new();
			IReadOnlyList<FacultyLawSchool> courses = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyLawSchools(IdUser));

			return Ok(courses);
		}
		
		

	}

}