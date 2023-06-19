using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksMilestone
{
    public long IdTask { get; set; }

    public long IdMilestoneExam { get; set; }

    public string IntroMessage { get; set; }

    public float RequiredScore { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual MilestoneExam IdMilestoneExamNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
