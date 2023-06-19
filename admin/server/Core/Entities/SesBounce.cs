using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesBounce
{
    public long IdSesNotification { get; set; }

    public string BounceType { get; set; }

    public string BounceSubType { get; set; }

    public DateTime Timestamp { get; set; }

    public string FeedbackId { get; set; }

    public string ReportingMta { get; set; }

    public virtual SesNotification IdSesNotificationNavigation { get; set; }
}
