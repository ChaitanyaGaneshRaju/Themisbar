using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksIntermittentQuize
{
    public long IdTask { get; set; }

    public long IdSubjectOutline { get; set; }

    public string IntroMessage { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
