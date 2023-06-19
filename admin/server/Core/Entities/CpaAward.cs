using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CpaAward
{
    public int Id { get; set; }

    public string AwardCode { get; set; }

    public string AwardDescription { get; set; }

    public string AwardBadge { get; set; }

    public DateTime? CreatedAt { get; set; }
}
