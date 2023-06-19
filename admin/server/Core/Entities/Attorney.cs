using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Attorney
{
    public long IdUser { get; set; }

    public DateOnly? ContractDate { get; set; }

    public bool? W9 { get; set; }

    public decimal? PayRatePerQuestion { get; set; }

    public bool? Available { get; set; }

    public int? Max { get; set; }

    public bool? Trusted { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<AttorneyAssignment> AttorneyAssignments { get; } = new List<AttorneyAssignment>();

    public virtual ICollection<AttorneyDailyMaximum> AttorneyDailyMaximums { get; } = new List<AttorneyDailyMaximum>();

    public virtual ICollection<AttorneyOutlineClassification> AttorneyOutlineClassifications { get; } = new List<AttorneyOutlineClassification>();

    public virtual User IdUserNavigation { get; set; }
}
