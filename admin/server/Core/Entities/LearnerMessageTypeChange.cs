using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnerMessageTypeChange
{
    public int IdLearnerMessageTypeChange { get; set; }

    public long IdMessage { get; set; }

    public long IdUser { get; set; }

    public string OldType { get; set; }

    public string NewType { get; set; }

    public DateTime Created { get; set; }
}
