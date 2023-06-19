using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MessageDetail
{
    public long IdMessage { get; set; }

    public string LearnerIdQuestion { get; set; }

    public long? LearnerIdSubjectOutline { get; set; }

    public string Lecture { get; set; }

    public int? IdMessageRelevantContent { get; set; }

    public bool? NumberOfQuestions { get; set; }

    public long? AdminIdQuestion { get; set; }

    public long? IdSubjectOutline { get; set; }

    public bool? ChangeFlag { get; set; }
}
