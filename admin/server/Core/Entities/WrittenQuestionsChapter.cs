using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class WrittenQuestionsChapter
{
    public long IdWrittenQuestion { get; set; }

    public long IdChapter { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }
}
