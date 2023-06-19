using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaskSchedule
{
    public long IdTask { get; set; }

    public DateTime? FixedDatetime { get; set; }

    public DateTime? AvailableStart { get; set; }

    public DateTime? AvailableEnd { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
