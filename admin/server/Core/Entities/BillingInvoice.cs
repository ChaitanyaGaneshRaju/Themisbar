using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class BillingInvoice
{
    public int IdBillingInvoice { get; set; }

    public long IdBilling { get; set; }

    public DateOnly Due { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Updated { get; set; }

    public DateOnly Issued { get; set; }

    public DateOnly Paid { get; set; }

    public int? IdPaymentInfo { get; set; }

    public string Memo { get; set; }
}
