using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SesNotification
{
    public long IdSesNotification { get; set; }

    public long IdSesMail { get; set; }

    public string NotificationType { get; set; }

    public virtual SesMail IdSesMailNavigation { get; set; }

    public virtual SesBounce SesBounce { get; set; }

    public virtual ICollection<SesBouncedRecipient> SesBouncedRecipients { get; } = new List<SesBouncedRecipient>();

    public virtual ICollection<SesComplainedRecipient> SesComplainedRecipients { get; } = new List<SesComplainedRecipient>();

    public virtual SesComplaint SesComplaint { get; set; }
}
