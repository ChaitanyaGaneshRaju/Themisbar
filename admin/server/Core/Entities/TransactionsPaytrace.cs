using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TransactionsPaytrace
{
    public int Id { get; set; }

    public string OrderId { get; set; }

    public string CustomerId { get; set; }

    public int AuthKey { get; set; }

    public int TransactionId { get; set; }

    public string Appcode { get; set; }

    public string Appmsg { get; set; }

    public string Avsresponse { get; set; }

    public string Cscresponse { get; set; }

    public string Email { get; set; }

    public decimal Amount { get; set; }

    public string CardType { get; set; }

    public sbyte Expmnth { get; set; }

    public sbyte Expyr { get; set; }

    public int First4 { get; set; }

    public int Last4 { get; set; }

    public string Bname { get; set; }

    public string ReturnUrl { get; set; }

    public string Type { get; set; }

    public int RefundedTransactionId { get; set; }

    public DateTime Datetime { get; set; }

    public string Error { get; set; }

    public bool Status { get; set; }
}
