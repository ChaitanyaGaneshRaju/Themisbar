using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PaymentPlan
{
    public int IdPaymentPlan { get; set; }

    public long IdReg { get; set; }

    public long IdAddon { get; set; }

    public long IdUser { get; set; }

    public long IdAuthorizedBy { get; set; }

    public decimal AmountDue { get; set; }

    public DateTime DateDue { get; set; }

    public bool Paid { get; set; }
}
