using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TasksEssay
{
    public long IdTaskEssay { get; set; }

    public long IdTask { get; set; }

    public string IntroMessage { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public int NumberOfQuestions { get; set; }

    public float TotalTime { get; set; }

    public float ScoresRange { get; set; }

    public int QuestionTimeLimit { get; set; }

    public int QuestionCharacterLimit { get; set; }

    public virtual Task IdTaskNavigation { get; set; }
}
