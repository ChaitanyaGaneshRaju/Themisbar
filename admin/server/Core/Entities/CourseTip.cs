using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseTip
{
    public long IdCourseTip { get; set; }

    public long IdCourse { get; set; }

    public string Type { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CourseTipDismissal> CourseTipDismissals { get; } = new List<CourseTipDismissal>();

    public virtual GenericTip GenericTip { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual TaskTypeTip TaskTypeTip { get; set; }
}
