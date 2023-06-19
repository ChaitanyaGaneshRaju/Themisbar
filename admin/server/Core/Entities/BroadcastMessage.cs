using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class BroadcastMessage
{
    public long IdMessage { get; set; }

    public sbyte Enabled { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }

    public string Type { get; set; }

    public int? IdTrack { get; set; }

    public virtual Message IdMessageNavigation { get; set; }
}
