using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CcpQuizAttempt
{
    public int Id { get; set; }

    public int CcpAttemptId { get; set; }

    public long IdCcpUser { get; set; }

    public long IdMultipleChoiceSet { get; set; }

    public DateTime? CompletedOn { get; set; }

    public DateTime? Created { get; set; }

    public virtual ICollection<CcpQuizAnswer> CcpQuizAnswers { get; } = new List<CcpQuizAnswer>();

    public virtual CcpUser IdCcpUserNavigation { get; set; }

    public virtual MultipleChoiceSet IdMultipleChoiceSetNavigation { get; set; }
}
