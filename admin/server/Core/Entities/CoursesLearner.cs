using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesLearner
{
    public long IdCourse { get; set; }

    public string CourseGuideType { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdUser { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? FirstLaunch { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
