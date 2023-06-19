using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AttorneyAssignmentHistory
{
    public long? IdMessage { get; set; }

    public long? IdUser { get; set; }

    public string AssignmentAction { get; set; }

    public long? SubmittedBy { get; set; }

    public string Comments { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public sbyte? Active { get; set; }

    public virtual Message IdMessageNavigation { get; set; }

    public virtual Attorney IdUserNavigation { get; set; }

    public virtual User SubmittedByNavigation { get; set; }
}
