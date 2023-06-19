using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnerMessage
{
    public long IdMessage { get; set; }

    public string Type { get; set; }

    public string AsignedStatus { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public sbyte Active { get; set; }

    public virtual AssignedResponder AssignedResponder { get; set; }

    public virtual Message IdMessageNavigation { get; set; }
}
