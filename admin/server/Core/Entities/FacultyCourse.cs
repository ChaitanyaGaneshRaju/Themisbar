using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Core.Entities;

public partial class FacultyCourse
{
	public long IdUser { get; set; }

	public long IdCourse { get; set; }
	public virtual Course Courses { get; set; }
}
