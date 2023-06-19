using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MilestoneExam
{
    public long IdMilestoneExam { get; set; }

    public string Name { get; set; }

    public sbyte QuestionsQuantity { get; set; }

    public float TimeLimit { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdOutlineClassification { get; set; }

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual ICollection<McqSetResult> McqSetResults { get; } = new List<McqSetResult>();

    public virtual ICollection<MilestoneExamsMultipleChoiceQuestion> MilestoneExamsMultipleChoiceQuestions { get; } = new List<MilestoneExamsMultipleChoiceQuestion>();

    public virtual ICollection<TasksMilestone> TasksMilestones { get; } = new List<TasksMilestone>();
}
