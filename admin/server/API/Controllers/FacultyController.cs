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
		public async Task<ActionResult<IReadOnlyList<FacultyCoursesDto>>> GetCourses(long facultyId)
		{
			FacultyDao fd = new();
			IReadOnlyList<FacultyCoursesDto> courses = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyCourses(facultyId));

			return Ok(courses);
		}
		
		[HttpGet("GetManagedCourses/{facultyId}")] 
		public async Task<ActionResult<IReadOnlyList<FacultyCoursesDto>>> GetManagedCourses(long facultyId)
		{
			FacultyDao fd = new();
			IReadOnlyList<FacultyCoursesDto> managedCourses = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyManagedCourses(facultyId));

			return Ok(managedCourses);
		}
		
		[HttpGet("GetUserDetails/{facultyId}")] 
		public async Task<ActionResult<IReadOnlyList<FacultyUserDetails>>> GetFacultyUserDetails(long facultyId)
		{
			FacultyDao fd = new();
			FacultyUserDetails facultyUserDetails = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyUserDetails(facultyId));

			return Ok(facultyUserDetails);
		}
		
		
		[HttpGet("GetLawSchools/{IdUser}")] 
		public async Task<ActionResult<IReadOnlyList<FacultyLawSchoolsDto>>> GetLawSchools(long IdUser)
		{
			FacultyDao fd = new();
			IReadOnlyList<FacultyLawSchoolsDto> courses = await System.Threading.Tasks.Task.FromResult(fd.GetFacultyLawSchools(IdUser));

			return Ok(courses);
		}
		
		

	}

}