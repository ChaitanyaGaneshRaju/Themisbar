using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTO;
using Infrastructure.Data;


namespace API.DAO
{
	public class FacultyCoursesDao
	{
		public long facultyId;
		private DataContext _context;

		public FacultyCoursesDao(long facultyId)
		{
			this.facultyId = facultyId;
			this._context = new DataContext();
		}
		
		public List<CourseIdNameDto> getFacultyCourses()
		{
			List<CourseIdNameDto> facultyCourses = (from fc in _context.FacultyCourses
			join c in _context.Courses on fc.IdCourse equals c.IdCourse
			where fc.IdUser == this.facultyId
			select new CourseIdNameDto
			{
				courseId = c.IdCourse,
				courseName = c.Name
			}).ToList();
			
			return facultyCourses;
				
		}
		
	}
}