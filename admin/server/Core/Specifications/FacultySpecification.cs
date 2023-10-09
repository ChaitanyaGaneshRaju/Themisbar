using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
	public class FacultySpecification
	{
		
	}
	public class FacultyLawSchoolsSpecification : BaseSpecification<FacultyLawSchool>
	{
		public FacultyLawSchoolsSpecification(long IdUser) : base(x => x.IdUser == IdUser )
		{
			AddInclude(x => x.LawSchool);
		}
	}
	
	public class FacultyCoursesSpecification : BaseSpecification<FacultyCourse>
	{
		public FacultyCoursesSpecification(long IdUser) : base(x => x.IdUser == IdUser )
		{
			// AddInclude(x => x.Course);
		}
	}
	
}