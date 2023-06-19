using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CcpQuizAnswer
{
    public int Id { get; set; }

    public int IdCcpQuizAttempt { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public long? IdAnswer { get; set; }

    public bool Skipped { get; set; }

    public bool? Correct { get; set; }

    public short? QuestionTime { get; set; }

    public DateTime? Created { get; set; }

    public virtual CcpQuizAttempt IdCcpQuizAttemptNavigation { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }
}
