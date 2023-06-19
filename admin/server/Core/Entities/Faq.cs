using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Faq
{
    public int Id { get; set; }

    public string QuestionText { get; set; }

    public string AnswerText { get; set; }

    public int CreatedById { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<FaqsSubjectOutline> FaqsSubjectOutlines { get; } = new List<FaqsSubjectOutline>();

    public virtual ICollection<QuestionKeyword> IdQuestionKeywords { get; } = new List<QuestionKeyword>();
}
