using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TransactionsAffirm
{
    public int Id { get; set; }

    public string OrderId { get; set; }

    public string CustomerId { get; set; }

    public string TransactionType { get; set; }

    public decimal Amount { get; set; }

    public string CheckoutToken { get; set; }

    public string AuthTranId { get; set; }

    public string AuthMerchantTranId { get; set; }

    public DateTime AuthTranAt { get; set; }

    public string VoidTranId { get; set; }

    public DateTime? VoidTranAt { get; set; }

    public string ChargeId { get; set; }

    public decimal? FeeAmount { get; set; }

    public string ChargeTranId { get; set; }

    public string ChargeMerchantTranId { get; set; }

    public DateTime? ChargeTranAt { get; set; }

    public decimal? RefundAmount { get; set; }

    public string RefundTranId { get; set; }

    public DateTime? RefundTranAt { get; set; }

    public string Currency { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
