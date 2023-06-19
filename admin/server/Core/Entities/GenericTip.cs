using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class GenericTip
{
    public long IdCourseTip { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public virtual CourseTip IdCourseTipNavigation { get; set; }
}
