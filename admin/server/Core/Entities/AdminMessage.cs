using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AdminMessage
{
    public long IdMessage { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }

    public sbyte Enabled { get; set; }

    public bool InProgress { get; set; }
}
