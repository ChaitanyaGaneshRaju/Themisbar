using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class WrittenQuestionsSubject
{
    public long IdWrittenQuestion { get; set; }

    public long IdSubjectOutline { get; set; }

    public bool IsPrimary { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }

    public virtual WrittenQuestion IdWrittenQuestionNavigation { get; set; }
}
