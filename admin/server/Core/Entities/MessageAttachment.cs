using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MessageAttachment
{
    public long IdMessageAttachment { get; set; }

    public long IdMessage { get; set; }

    public string AttachmentName { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }

    public virtual Message IdMessageNavigation { get; set; }
}
