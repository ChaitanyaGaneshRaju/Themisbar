using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MultipleChoiceSetsMultipleChoiceQuestion
{
    public long IdMultipleChoiceQuestion { get; set; }

    public long IdMultipleChoiceSet { get; set; }

    public byte Position { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }

    public virtual MultipleChoiceSet IdMultipleChoiceSetNavigation { get; set; }
}
