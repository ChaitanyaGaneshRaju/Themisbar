using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseLearnerHoliday
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public int IdCourseHoliday { get; set; }

    public bool OptOut { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual CourseHoliday IdCourseHolidayNavigation { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
