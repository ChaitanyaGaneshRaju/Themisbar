using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MilestoneExamsMultipleChoiceQuestion
{
    public long IdMultipleChoiceQuestion { get; set; }

    public long IdMilestoneExam { get; set; }

    public sbyte Position { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual MilestoneExam IdMilestoneExamNavigation { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }
}
