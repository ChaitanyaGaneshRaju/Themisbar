using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksMultipleChoice
{
    public long IdTaskMultipleChoice { get; set; }

    public long IdTask { get; set; }

    public long? IdMultipleChoiceSet { get; set; }

    public string IntroMessage { get; set; }

    public int NumberOfQuestions { get; set; }

    public float TimePerQuestion { get; set; }

    public float RequiredScorePercentage { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual ICollection<TasksMultipleChoiceSubject> TasksMultipleChoiceSubjects { get; } = new List<TasksMultipleChoiceSubject>();
}
