using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnersSelfAssessElement
{
    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public long IdWrittenQuestion { get; set; }

    public int IdElement { get; set; }

    public bool IsSelected { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool? Active { get; set; }
}
