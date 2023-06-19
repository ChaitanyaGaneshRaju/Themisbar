using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class BillingInvoiceSnapshot
{
    public int Id { get; set; }

    public int? Int11PrimaryKey { get; set; }

    public int? IdBillingInvoice { get; set; }

    public int? IdUser { get; set; }

    public string SaveState { get; set; }

    public DateTime? Created { get; set; }
}
