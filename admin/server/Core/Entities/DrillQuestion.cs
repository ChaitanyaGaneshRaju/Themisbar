using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DrillQuestion
{
    public int Id { get; set; }

    public long IdSubjectOutline { get; set; }

    public string QuestionText { get; set; }

    public string AnswerText { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }
}
