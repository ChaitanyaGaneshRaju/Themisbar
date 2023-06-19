using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Adviser
{
    public long IdUser { get; set; }

    public int MaxStudentsPerClassification { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public bool? W9 { get; set; }

    public bool? Contract { get; set; }

    public DateOnly? ContractExamDate { get; set; }

    public virtual ICollection<AdvisersOutlineClassification> AdvisersOutlineClassifications { get; } = new List<AdvisersOutlineClassification>();

    public virtual ICollection<CoursesLearnersAdviser> CoursesLearnersAdvisers { get; } = new List<CoursesLearnersAdviser>();

    public virtual User IdUserNavigation { get; set; }
}
