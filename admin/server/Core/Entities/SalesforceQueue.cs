using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SalesforceQueue
{
    public int Id { get; set; }

    public string Type { get; set; }

    public string Status { get; set; }

    public string ItemId { get; set; }

    public string Comments { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public DateTime SentOn { get; set; }
}
