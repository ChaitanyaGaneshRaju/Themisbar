using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseTipDismissal
{
    public long IdCourseTip { get; set; }

    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public virtual CourseTip IdCourseTipNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
