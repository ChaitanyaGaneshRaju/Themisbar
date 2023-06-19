using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class IntroductionSurveyQuestion
{
    public long IdIntroductionSurveyQuestion { get; set; }

    public long IdCourse { get; set; }

    public string QuestionText { get; set; }

    public string Multiple1 { get; set; }

    public string Multiple2 { get; set; }

    public string Multiple3 { get; set; }

    public string Multiple4 { get; set; }

    public string Multiple5 { get; set; }

    public string Multiple6 { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public string QuestionType { get; set; }

    public virtual Course IdCourseNavigation { get; set; }
}
