using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Invoice
{
    public int Id { get; set; }

    public int? IdVendor { get; set; }

    public string Name { get; set; }

    public string Notes { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual Vendor IdVendorNavigation { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; } = new List<InvoiceItem>();

    public virtual ICollection<Course> IdCourses { get; } = new List<Course>();
}
