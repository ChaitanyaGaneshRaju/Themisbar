using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class WrittenQuestion
{
    public long IdWrittenQuestion { get; set; }

    public string WrittenQuestionType { get; set; }

    public string Name { get; set; }

    /// <summary>
    /// time in minutes
    /// </summary>
    public int TimeLimit { get; set; }

    public int CharactersLimit { get; set; }

    public bool Enabled { get; set; }

    public bool Graded { get; set; }

    public string QuestionText { get; set; }

    public string Notes { get; set; }

    public string QuestionModelAnswer { get; set; }

    public bool HasEval { get; set; }

    public sbyte? OriginSession { get; set; }

    public short? OriginYear { get; set; }

    public short? OriginPosition { get; set; }

    public DateTime Created { get; set; }

    /// <summary>
    /// 
    /// 
    /// </summary>
    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<EssayIssue> EssayIssues { get; } = new List<EssayIssue>();

    public virtual ICollection<EssayTaskReset> EssayTaskResets { get; } = new List<EssayTaskReset>();

    public virtual ICollection<TasksEssaysQuestion> TasksEssaysQuestions { get; } = new List<TasksEssaysQuestion>();

    public virtual ICollection<WrittenQuestionsSubject> WrittenQuestionsSubjects { get; } = new List<WrittenQuestionsSubject>();
}
