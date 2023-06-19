using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EssayIssueConclusion
{
    public int Id { get; set; }

    public int? IdIssue { get; set; }

    public sbyte Position { get; set; }

    public string ConclusionText { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual EssayIssue IdIssueNavigation { get; set; }
}
