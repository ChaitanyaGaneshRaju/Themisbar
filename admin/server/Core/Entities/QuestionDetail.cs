using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class QuestionDetail
{
    public long IdQuestion { get; set; }

    public string CognitiveSkill { get; set; }

    public virtual Question IdQuestionNavigation { get; set; }
}
