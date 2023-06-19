using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnersSelfAssessment
{
    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public long IdWrittenQuestion { get; set; }

    public DateTime SelfAssessmentCompleted { get; set; }

    public DateTime TaskCompleted { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
