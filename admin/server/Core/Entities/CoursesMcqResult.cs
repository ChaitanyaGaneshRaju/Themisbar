using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesMcqResult
{
    public long IdCourse { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public int Total { get; set; }

    public int Correct { get; set; }

    public int Time { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }
}
