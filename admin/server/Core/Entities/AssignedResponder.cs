using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// this table is needed to avoid having a not null foreign key
/// </summary>
public partial class AssignedResponder
{
    public long IdMessage { get; set; }

    /// <summary>
    /// id of the user assigned to anwer this message
    /// </summary>
    public long IdUser { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }

    public virtual LearnerMessage IdMessageNavigation { get; set; }
}
