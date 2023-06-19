using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EssayIssueElement
{
    public int Id { get; set; }

    public int? IdEssayIssue { get; set; }

    public string Type { get; set; }

    public sbyte Position { get; set; }

    public string ElementText { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual EssayIssue IdEssayIssueNavigation { get; set; }
}
