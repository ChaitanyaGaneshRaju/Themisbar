using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Flashcard
{
    public int Id { get; set; }

    public int IdReg { get; set; }

    public long IdSubjectOutline { get; set; }

    public string QuestionText { get; set; }

    public string AnswerText { get; set; }

    public string Status { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual CourseEnrollment IdRegNavigation { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }
}
