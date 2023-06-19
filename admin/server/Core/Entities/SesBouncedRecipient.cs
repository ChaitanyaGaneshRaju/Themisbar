using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesBouncedRecipient
{
    public long IdSesBouncedRecipient { get; set; }

    public long IdSesNotification { get; set; }

    public string EmailAddress { get; set; }

    public string Action { get; set; }

    public string Status { get; set; }

    public string DiagnosticCode { get; set; }

    public long? IdUser { get; set; }

    public virtual SesNotification IdSesNotificationNavigation { get; set; }
}
