using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaskEssaysSubjectOutline
{
    public long IdTaskEssay { get; set; }

    public long IdSubjectOutline { get; set; }

    public bool IsPrimary { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
