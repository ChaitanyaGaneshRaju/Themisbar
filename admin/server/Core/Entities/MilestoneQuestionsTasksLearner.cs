using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MilestoneQuestionsTasksLearner
{
    public long IdUser { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public long IdTask { get; set; }

    public long IdAnswer { get; set; }

    public sbyte ReviewLater { get; set; }

    public short? QuestionTime { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
