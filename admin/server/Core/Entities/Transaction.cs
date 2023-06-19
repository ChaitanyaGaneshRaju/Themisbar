using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Transaction
{
    public int IdTransaction { get; set; }

    public int? IdReg { get; set; }

    public int? IdAddon { get; set; }

    public int? IdAdjustmentCategory { get; set; }

    public int? IdDiscountCategory { get; set; }

    public int? IdPromoType { get; set; }

    public int? IdPromoConditional { get; set; }

    public int? IdBilling { get; set; }

    public long IdBillingInvoice { get; set; }

    public int? IdPaymentInformation { get; set; }

    public int? IdRefundInformation { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Amount { get; set; }

    public string Type { get; set; }

    public string Mode { get; set; }

    public int? RequestedBy { get; set; }

    public int? AuthorizedBy { get; set; }

    public int? AccountingYear { get; set; }

    public DateTime BillPayDate { get; set; }
}
