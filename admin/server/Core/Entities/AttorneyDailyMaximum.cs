using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AttorneyDailyMaximum
{
    public long IdUser { get; set; }

    public bool Day { get; set; }

    public int? DailyMax { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Attorney IdUserNavigation { get; set; }
}
