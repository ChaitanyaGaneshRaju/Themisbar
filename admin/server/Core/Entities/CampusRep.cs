using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CampusRep
{
    public long IdUser { get; set; }

    public bool IsActive { get; set; }

    public DateTime Date { get; set; }

    public string Notes { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public virtual Learner IdUserNavigation { get; set; }

    public virtual ICollection<LearnersCampusRep> LearnersCampusReps { get; } = new List<LearnersCampusRep>();
}
