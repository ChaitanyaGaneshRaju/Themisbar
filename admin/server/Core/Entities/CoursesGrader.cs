using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesGrader
{
    public long IdCourse { get; set; }

    public long IdUser { get; set; }

    public int MaxCount { get; set; }

    public decimal? Rate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual Grader IdUserNavigation { get; set; }
}
