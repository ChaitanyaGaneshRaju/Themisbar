using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AttorneyAssignment
{
    public long IdUser { get; set; }

    public long IdMessage { get; set; }

    public DateTime? RevisedDatetime { get; set; }

    public DateTime AnsweredDatetime { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Message IdMessageNavigation { get; set; }

    public virtual Attorney IdUserNavigation { get; set; }
}
