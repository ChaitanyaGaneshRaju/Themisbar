using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MilestoneExamTaskAttempt
{
    public int IdMilestoneExamTaskAttempt { get; set; }

    public long IdTask { get; set; }

    public long IdUser { get; set; }

    public DateTime StartedDatetime { get; set; }

    public DateTime? CompletedDatetime { get; set; }

    public sbyte ExamReset { get; set; }

    public int ResetIdUser { get; set; }

    public string ClosedType { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
