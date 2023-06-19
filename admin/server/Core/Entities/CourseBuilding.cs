using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseBuilding
{
    public long IdTask { get; set; }

    public DateOnly ScheduledDate { get; set; }

    public DateTime VerifiedOn { get; set; }

    public long? VerifiedBy { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
