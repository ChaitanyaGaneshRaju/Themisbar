using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesMail
{
    public long IdSesMail { get; set; }

    public DateTime Timestamp { get; set; }

    public string MessageId { get; set; }

    public string Source { get; set; }

    public string SourceArn { get; set; }

    public string SendingAccountId { get; set; }

    public string Destination { get; set; }

    public virtual ICollection<SesNotification> SesNotifications { get; } = new List<SesNotification>();
}
