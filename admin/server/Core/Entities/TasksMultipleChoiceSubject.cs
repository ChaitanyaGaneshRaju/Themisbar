using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksMultipleChoiceSubject
{
    public long IdSubjectOutline { get; set; }

    public long IdChapter { get; set; }

    public long IdTaskMultipleChoice { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }

    public virtual TasksMultipleChoice IdTaskMultipleChoiceNavigation { get; set; }
}
