using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AssessmentQuestion
{
    public long IdAssessmentQuestion { get; set; }

    public long IdQuestion { get; set; }

    public long IdVideo { get; set; }

    public bool? IsBaseline { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Question IdQuestionNavigation { get; set; }

    public virtual Video IdVideoNavigation { get; set; }

    public virtual ICollection<IntermittentQuizQuestionResult> IntermittentQuizQuestionResults { get; } = new List<IntermittentQuizQuestionResult>();
}
