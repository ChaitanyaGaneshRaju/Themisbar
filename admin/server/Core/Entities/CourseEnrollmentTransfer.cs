using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseEnrollmentTransfer
{
    public int Id { get; set; }

    public long IdCourseFrom { get; set; }

    public long IdCourseTo { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? Completed { get; set; }

    public long IdReg { get; set; }
}
