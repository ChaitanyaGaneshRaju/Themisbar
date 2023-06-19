using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ReviewResolution
{
    public int IdReviewNotification { get; set; }

    public long ResolvedBy { get; set; }

    public string Comments { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual User ResolvedByNavigation { get; set; }
}
