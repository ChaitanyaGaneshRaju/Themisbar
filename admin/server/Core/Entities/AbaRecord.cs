using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AbaRecord
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public int? AbaNumber { get; set; }

    public int? AbaCourse { get; set; }

    public int? BarCourse { get; set; }

    public DateTime? Created { get; set; }

    public virtual CourseEnrollment AbaCourseNavigation { get; set; }

    public virtual CourseEnrollment BarCourseNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
