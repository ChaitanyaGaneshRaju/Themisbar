using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseLearnerStatistic
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public int? MbeTotalAnswered { get; set; }

    public int? MbeTotalCorrect { get; set; }

    public int? MbeTotalTime { get; set; }

    public int? GradedEssaysCompleted { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
