using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class VideoSet
{
    public long IdVideoSet { get; set; }

    public string Name { get; set; }

    public long IdSubjectOutline { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Video> Videos { get; } = new List<Video>();
}
