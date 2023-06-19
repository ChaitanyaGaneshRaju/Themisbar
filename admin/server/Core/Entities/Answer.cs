using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Answer
{
    public long IdAnswer { get; set; }

    public long IdQuestion { get; set; }

    public string AnswerText { get; set; }

    public bool IsCorrect { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public long Active { get; set; }

    public virtual ICollection<AnswerStrikethrough> AnswerStrikethroughs { get; } = new List<AnswerStrikethrough>();

    public virtual ICollection<ExamAnswerStrikethrough> ExamAnswerStrikethroughs { get; } = new List<ExamAnswerStrikethrough>();

    public virtual Question IdQuestionNavigation { get; set; }

    public virtual ICollection<IntermittentQuizQuestionResult> IntermittentQuizQuestionResults { get; } = new List<IntermittentQuizQuestionResult>();
}
