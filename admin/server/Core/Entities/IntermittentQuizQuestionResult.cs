using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class IntermittentQuizQuestionResult
{
    public long IdAssessmentQuestion { get; set; }

    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public long IdAnswer { get; set; }

    public bool IsBaseline { get; set; }

    public short? QuestionTime { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual Answer IdAnswerNavigation { get; set; }

    public virtual AssessmentQuestion IdAssessmentQuestionNavigation { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
