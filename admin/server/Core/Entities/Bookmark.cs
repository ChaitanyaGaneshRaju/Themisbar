using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Bookmark
{
    public long IdSubject { get; set; }

    public long IdSection { get; set; }

    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
