using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksVideosLearner
{
    public long IdTask { get; set; }

    public long IdVideo { get; set; }

    public long IdUser { get; set; }

    public string State { get; set; }

    public float Score { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
