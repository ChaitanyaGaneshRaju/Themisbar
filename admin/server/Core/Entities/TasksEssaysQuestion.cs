using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksEssaysQuestion
{
    public long IdTaskEssay { get; set; }

    public long IdEssayQuestion { get; set; }

    public sbyte Position { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual WrittenQuestion IdEssayQuestionNavigation { get; set; }
}
