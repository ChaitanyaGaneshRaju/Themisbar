using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LogEventType
{
    public int IdLogEventType { get; set; }

    public string SystemName { get; set; }

    public string DisplayName { get; set; }

    public string Context { get; set; }

    public string TransType { get; set; }

    public int Order { get; set; }
}
