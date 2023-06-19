using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class McqFeedback
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public long IdMultipleChoiceQuestion { get; set; }

    public string Feedback { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual MultipleChoiceQuestion IdMultipleChoiceQuestionNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
