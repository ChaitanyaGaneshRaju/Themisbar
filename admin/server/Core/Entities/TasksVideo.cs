using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksVideo
{
    public long IdTask { get; set; }

    public long IdVideo { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual Video IdVideoNavigation { get; set; }
}
