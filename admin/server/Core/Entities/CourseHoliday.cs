using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseHoliday
{
    public int IdCourseHoliday { get; set; }

    public long IdCourse { get; set; }

    public DateTime HolidayDate { get; set; }

    public string Message { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual ICollection<CourseLearnerHoliday> CourseLearnerHolidays { get; } = new List<CourseLearnerHoliday>();
}
