using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DrillSet
{
    public int Id { get; set; }

    public long IdOutlineClassification { get; set; }

    public string Name { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual ICollection<TasksDrill> TasksDrills { get; } = new List<TasksDrill>();
}
