using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class OutlinesClassification
{
    public long IdOutlineClassification { get; set; }

    public string Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<DrillSet> DrillSets { get; } = new List<DrillSet>();

    public virtual ICollection<MilestoneExam> MilestoneExams { get; } = new List<MilestoneExam>();

    public virtual ICollection<MultipleChoiceSet> MultipleChoiceSets { get; } = new List<MultipleChoiceSet>();

    public virtual ICollection<PromosOutlinesClassification> PromosOutlinesClassifications { get; } = new List<PromosOutlinesClassification>();

    public virtual ICollection<SubjectOutline> SubjectOutlines { get; } = new List<SubjectOutline>();

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
