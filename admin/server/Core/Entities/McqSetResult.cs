using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class McqSetResult
{
    public long IdMilestoneExam { get; set; }

    public long IdCourse { get; set; }

    public long AnsweredCount { get; set; }

    public long CorrectCount { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual MilestoneExam IdMilestoneExamNavigation { get; set; }
}
