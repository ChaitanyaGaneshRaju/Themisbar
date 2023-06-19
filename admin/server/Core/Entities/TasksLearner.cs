using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksLearner
{
    public long IdTask { get; set; }

    public DateOnly TaskDate { get; set; }

    public DateTime CompletedDatetime { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdUser { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
