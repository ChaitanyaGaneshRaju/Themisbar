using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class VideoLink
{
    public int IdVideoLinks { get; set; }

    public string VideoUrl { get; set; }

    public string SubtitleUrl { get; set; }

    public string VideoType { get; set; }

    public long IdVideo { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual Video IdVideoNavigation { get; set; }
}
