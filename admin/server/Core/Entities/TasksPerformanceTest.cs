using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksPerformanceTest
{
    public long IdTask { get; set; }

    public string IntroMessage { get; set; }

    public float TimeLimit { get; set; }

    public long CharacterCount { get; set; }

    public string PdfEssayS3Url { get; set; }

    public string ModelAnswer { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
