using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class InvoiceItem
{
    public int Id { get; set; }

    public int IdInvoice { get; set; }

    public long? IdCourse { get; set; }

    public string Notes { get; set; }

    public decimal Amount { get; set; }

    public virtual Invoice IdInvoiceNavigation { get; set; }
}
