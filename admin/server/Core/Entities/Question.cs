using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Question
{
    public long IdQuestion { get; set; }

    public long IdSection { get; set; }

    public bool Enabled { get; set; }

    public string QuestionStem { get; set; }

    public string QuestionTitle { get; set; }

    public string Media { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Answer> Answers { get; } = new List<Answer>();

    public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; } = new List<AssessmentQuestion>();

    public virtual Section IdSectionNavigation { get; set; }

    public virtual ICollection<MultipleChoiceQuestion> MultipleChoiceQuestions { get; } = new List<MultipleChoiceQuestion>();

    public virtual QuestionDetail QuestionDetail { get; set; }
}
