using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EssayIssue
{
    public int Id { get; set; }

    public long IdWrittenQuestion { get; set; }

    public int? IdParentIssue { get; set; }

    public sbyte Position { get; set; }

    public sbyte Weight { get; set; }

    public string IssueText { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<EssayIssueConclusion> EssayIssueConclusions { get; } = new List<EssayIssueConclusion>();

    public virtual ICollection<EssayIssueElement> EssayIssueElements { get; } = new List<EssayIssueElement>();

    public virtual WrittenQuestion IdWrittenQuestionNavigation { get; set; }
}
