using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TransactionsTotal
{
    public int Id { get; set; }

    public long IdReg { get; set; }

    public long IdCourse { get; set; }

    public int CourseYear { get; set; }

    public bool? RegType { get; set; }

    public long IdCourseType { get; set; }

    public int IdLawSchool { get; set; }

    public int? IdPaymentPlan { get; set; }

    public int IdSeason { get; set; }

    public string SeasonAbv { get; set; }

    public long IdOutlineClassification { get; set; }

    public string OutlineClassificationDescription { get; set; }

    public decimal Tuition { get; set; }

    public decimal MaxPromo { get; set; }

    public decimal Floor { get; set; }

    public decimal TotalPayment { get; set; }

    public decimal TotalRefunded { get; set; }

    public decimal TotalPaid { get; set; }

    public decimal TotalAdjustments { get; set; }

    public decimal BalanceDue { get; set; }

    public decimal TotalBilled { get; set; }

    public decimal BalanceDueBilling { get; set; }

    public decimal TotalPromo { get; set; }

    public decimal? TaxExempt { get; set; }

    public bool Registered { get; set; }

    public bool LaunchOverwrite { get; set; }

    public bool? Access { get; set; }

    public bool? OnReports { get; set; }

    public bool PaidInFull { get; set; }

    public bool PaidInFullBilling { get; set; }

    public bool FloorMet { get; set; }

    public bool Payment { get; set; }

    public bool PfAbove { get; set; }

    public bool PfBelow { get; set; }

    public bool PfFree { get; set; }

    public bool PartialAbove { get; set; }

    public bool PartialBelow { get; set; }

    public bool UnpaidFirm { get; set; }
}
