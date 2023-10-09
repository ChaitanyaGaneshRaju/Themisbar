using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DTO
{
	public class FacultyCoursesDto
	{
		public long IdUser { get; set; }
		public long IdCourse { get; set; }
		public string Name { get; set; }
	}
	
	public class FacultyLawSchoolsDto
	{
		public long IdUser { get; set; }
		public long IdLawSchool { get; set; }
		public string Name { get; set; }
	}
	
}