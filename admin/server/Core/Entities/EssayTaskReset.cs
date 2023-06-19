using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EssayTaskReset
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdWrittenQuestion { get; set; }

    public long IdTask { get; set; }

    public string Answer { get; set; }

    public short? QuestionTime { get; set; }

    public DateOnly? SubmissionDate { get; set; }

    public long ResetBy { get; set; }

    public DateTime? TaskCompletedOn { get; set; }

    public string Reason { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Task IdTaskNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }

    public virtual WrittenQuestion IdWrittenQuestionNavigation { get; set; }

    public virtual User ResetByNavigation { get; set; }
}
