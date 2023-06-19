using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SelfAssessmentPart
{
    public int Id { get; set; }

    public int IdWrittenQuestion { get; set; }

    public int Position { get; set; }

    public string Name { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool? Active { get; set; }
}
