using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SelfAssessmentElement
{
    public int Id { get; set; }

    public int IdSelfAssessmentPart { get; set; }

    public string AssessmentType { get; set; }

    public int Position { get; set; }

    public string Question { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
