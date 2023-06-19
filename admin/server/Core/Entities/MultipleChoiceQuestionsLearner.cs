using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MultipleChoiceQuestionsLearner
{
    public long Id { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public long? IdTask { get; set; }

    public bool CorrectAnswer { get; set; }

    public short? QuestionTime { get; set; }

    public long IdAnswer { get; set; }

    public int? IdMcqSession { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AnswerStrikethrough> AnswerStrikethroughs { get; } = new List<AnswerStrikethrough>();
}
