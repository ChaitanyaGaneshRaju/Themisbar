using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// both broadcast messages and reply messages need to be marked
/// </summary>
public partial class MessageStatus
{
    public long IdMessage { get; set; }

    public long IdUser { get; set; }

    public string ReadStatus { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }

    public virtual Message IdMessageNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
