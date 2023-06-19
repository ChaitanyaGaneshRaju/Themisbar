using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class RefundInfo
{
    public int IdRefundInfo { get; set; }

    public string Type { get; set; }

    public int IdCcTransaction { get; set; }

    public string CardType { get; set; }

    public string CcNumber { get; set; }

    public string Initials { get; set; }

    public string NameOnCheck { get; set; }

    public string CheckNumber { get; set; }

    public bool BillingPayment { get; set; }

    public string Processor { get; set; }

    public string ReferenceNumber { get; set; }
}
