using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnersCampusRep
{
    public long IdUser { get; set; }

    public long IdCampusRep { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual CampusRep IdCampusRepNavigation { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
