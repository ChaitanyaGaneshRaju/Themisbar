using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AssementQuestion
{
    public long IdAssessmentQuestion { get; set; }

    public bool Enabled { get; set; }

    public string QuestionStem { get; set; }

    public long IdVideo { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdSection { get; set; }

    public virtual Section IdSectionNavigation { get; set; }

    public virtual Video IdVideoNavigation { get; set; }
}
