using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AdvisersOutlineClassification
{
    public long IdOutlineClassification { get; set; }

    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public DateOnly? ExamDate { get; set; }

    public int? MaxCount { get; set; }

    public int? Rate { get; set; }

    public virtual Adviser IdUserNavigation { get; set; }
}
