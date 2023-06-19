using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TrackTask
{
    public int IdTrack { get; set; }

    public long IdTask { get; set; }

    public DateTime AvailableStart { get; set; }

    public DateTime AvailableEnd { get; set; }

    public DateOnly Scheduled { get; set; }

    public int Position { get; set; }

    public bool ExcludeFromDirected { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual Track IdTrackNavigation { get; set; }
}
