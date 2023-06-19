using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LogEvent
{
    public int IdLogEvent { get; set; }

    public long IdLogEventType { get; set; }

    public long IdUserSource { get; set; }

    public long IdUserTarget { get; set; }

    public long IdRegTarget { get; set; }

    public long IdAddonTarget { get; set; }

    public long IdBillingInvoiceTarget { get; set; }

    public string Message { get; set; }

    public string Amount { get; set; }

    public string TransType { get; set; }

    public string ExtraData { get; set; }

    public decimal Balance { get; set; }

    public DateTime Datetime { get; set; }
}
