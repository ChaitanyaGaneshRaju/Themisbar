using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksDrill
{
    public long IdTask { get; set; }

    public int IdDrillSet { get; set; }

    public string IntroMessage { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual DrillSet IdDrillSetNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
