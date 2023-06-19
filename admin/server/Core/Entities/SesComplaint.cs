using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesComplaint
{
    public long IdSesNotification { get; set; }

    public DateTime Timestamp { get; set; }

    public string FeedbackId { get; set; }

    public string UserAgent { get; set; }

    public string ComplaintFeedbackType { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public virtual SesNotification IdSesNotificationNavigation { get; set; }
}
