using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MultipleChoiceSubjectsUsersAverage
{
    public string QuestionAverageType { get; set; }

    public long IdQuestionAverage { get; set; }

    public long Correct { get; set; }

    public long Total { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public sbyte? Active { get; set; }
}
