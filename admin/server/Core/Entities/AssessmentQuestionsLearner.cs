using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AssessmentQuestionsLearner
{
    public int IdTask { get; set; }

    public int IdAssessmentQuestion { get; set; }

    public int IdQuestion { get; set; }

    public int IdVideo { get; set; }

    public int IdUser { get; set; }

    public int IdAnswer { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
