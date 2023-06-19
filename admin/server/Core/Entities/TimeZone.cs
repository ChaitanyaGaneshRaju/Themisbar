using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TimeZone
{
    public int IdTimeZone { get; set; }

    public string SystemName { get; set; }

    public string FriendlyName { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
