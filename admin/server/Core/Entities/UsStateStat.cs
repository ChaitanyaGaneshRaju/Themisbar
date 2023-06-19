using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsStateStat
{
    public int Id { get; set; }

    public string UsStateCode { get; set; }

    public int? Year { get; set; }

    public int? NumTakingTheBar { get; set; }

    public int? NumPassingTheBar { get; set; }

    public int? NumFirstTimersTakingTheBar { get; set; }

    public int? NumFirstTimersPassingTheBar { get; set; }

    public int? OurPublishedFirstTimePassRate { get; set; }

    public int? PublicPublishedFirstTimePassRate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
