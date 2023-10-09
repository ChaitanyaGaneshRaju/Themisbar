using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class FacultyLawSchool
{
	public long IdUser { get; set; }

	public long IdLawSchool { get; set; }
	
	public virtual LawSchool LawSchool {get; set;} 
}
