using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ExamAnswerStrikethrough
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public long IdAnswer { get; set; }

    public DateTime? Created { get; set; }

    public virtual Answer IdAnswerNavigation { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
