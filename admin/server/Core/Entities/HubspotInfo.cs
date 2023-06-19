using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class HubspotInfo
{
    public long IdUser { get; set; }

    public int? Vid { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
