using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DAO;
using Core.DTO;
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

		[HttpGet("{facultyId}")]
		public async Task<ActionResult<List<CourseIdNameDto>>> GetCourses(long facultyId)
		{
			FacultyCoursesDao fcd = new(facultyId);
			
			List<CourseIdNameDto> courses = await Task.FromResult(fcd.getFacultyCourses());
			
			return Ok(courses);
		}
		
	}

}