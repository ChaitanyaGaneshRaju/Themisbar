using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ReplyMessage
{
    public long IdMessage { get; set; }

    public long IdRepliedMessage { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Created { get; set; }

    public sbyte Active { get; set; }
}
