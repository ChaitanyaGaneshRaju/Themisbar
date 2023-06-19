using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesLearnersGrader
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public long IdGrader { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Grader IdGraderNavigation { get; set; }
}
