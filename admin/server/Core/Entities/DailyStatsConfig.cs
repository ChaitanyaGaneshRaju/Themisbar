using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DailyStatsConfig
{
    public int Id { get; set; }

    public string Subject { get; set; }

    public string ToAddress { get; set; }

    public string Body { get; set; }

    public bool? SendEmail { get; set; }
}
