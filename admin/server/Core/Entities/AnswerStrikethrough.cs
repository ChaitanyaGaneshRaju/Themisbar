using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AnswerStrikethrough
{
    public int Id { get; set; }

    public long IdMultipleChoiceQuestionLearner { get; set; }

    public long IdAnswer { get; set; }

    public DateTime? Created { get; set; }

    public virtual Answer IdAnswerNavigation { get; set; }

    public virtual MultipleChoiceQuestionsLearner IdMultipleChoiceQuestionLearnerNavigation { get; set; }
}
