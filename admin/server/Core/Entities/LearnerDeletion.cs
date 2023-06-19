using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnerDeletion
{
    public long IdUser { get; set; }

    public long DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long DuplicateUserId { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
