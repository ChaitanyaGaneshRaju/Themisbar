using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ReviewNotification
{
    public int Id { get; set; }

    public string QuestionType { get; set; }

    public int IdQuestion { get; set; }

    public long CreatedBy { get; set; }

    public string Comments { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual User CreatedByNavigation { get; set; }
}
