using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaskOverride
{
    public int IdReg { get; set; }

    public string TaskType { get; set; }

    public float? QuestionTime { get; set; }

    public float? TaskTime { get; set; }

    public int? CharacterLimit { get; set; }

    public float? RequiredScore { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual CourseEnrollment IdRegNavigation { get; set; }
}
