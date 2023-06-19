using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksSubjectOutline
{
    public long IdTask { get; set; }

    public long IdChapter { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Chapter IdChapterNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
