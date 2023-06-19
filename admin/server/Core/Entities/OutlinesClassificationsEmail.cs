using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class OutlinesClassificationsEmail
{
    public string IdOutlineClassification { get; set; }

    public string Email { get; set; }

    public string AdviserQuestionOverrideEmail { get; set; }

    public string StudyStrategiesOverrideEmail { get; set; }

    public string GradedEssayOverrideEmail { get; set; }
}
