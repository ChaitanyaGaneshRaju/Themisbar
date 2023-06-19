using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromoCondition
{
    public int IdPromoCondition { get; set; }

    public int IdPromoConditional { get; set; }

    public int? IdAddonType { get; set; }

    public bool PaymentRequirement { get; set; }

    public decimal Balance { get; set; }

    public decimal Amount { get; set; }

    public bool Action { get; set; }

    public string InvoiceNote { get; set; }

    public DateTime Deadline { get; set; }

    public bool? Active { get; set; }
}
