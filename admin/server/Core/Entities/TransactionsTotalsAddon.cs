using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TransactionsTotalsAddon
{
    public int Id { get; set; }

    public int IdReg { get; set; }

    public int IdAddon { get; set; }

    public int IdCourse { get; set; }

    public int CourseYear { get; set; }

    public int IdAddonType { get; set; }

    public decimal Fee { get; set; }

    public decimal TotalPayment { get; set; }

    public decimal TotalRefunded { get; set; }

    public decimal TotalPaid { get; set; }

    public decimal TotalAdjustments { get; set; }

    public decimal BalanceDue { get; set; }

    public decimal TotalBilled { get; set; }

    public decimal BalanceDueBilling { get; set; }

    public decimal TotalPromo { get; set; }

    public bool PaidInFull { get; set; }

    public bool PaidInFullBilling { get; set; }

    public int? IdPaymentPlan { get; set; }
}
