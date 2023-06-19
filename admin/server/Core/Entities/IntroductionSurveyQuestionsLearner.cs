using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class IntroductionSurveyQuestionsLearner
{
    public long IdIntroductionSurveyQuestion { get; set; }

    public string Answer { get; set; }

    public bool Multiple1Selected { get; set; }

    public bool Multiple2Selected { get; set; }

    public bool Multiple3Selected { get; set; }

    public bool Multiple4Selected { get; set; }

    public bool Multiple5Selected { get; set; }

    public bool Multiple6Selected { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public long IdUser { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
