using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesComplainedRecipient
{
    public long IdSesComplainedRecipient { get; set; }

    public long IdSesNotification { get; set; }

    public string EmailAddress { get; set; }

    public long? IdUser { get; set; }

    public virtual SesNotification IdSesNotificationNavigation { get; set; }
}
