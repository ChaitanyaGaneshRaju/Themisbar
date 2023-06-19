using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class WrittenQuestionsTasksLearner
{
    public long IdWrittenQuestion { get; set; }

    public long IdUser { get; set; }

    public string Answer { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdTask { get; set; }

    public short? QuestionTime { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
