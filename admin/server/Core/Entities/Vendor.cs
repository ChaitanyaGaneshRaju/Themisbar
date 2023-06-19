using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Vendor
{
    public int Id { get; set; }

    public string VendorType { get; set; }

    public long? IdLawSchool { get; set; }

    public long? IdLawFirm { get; set; }

    public string Name { get; set; }

    public string ContactEmail { get; set; }

    public string ContactName { get; set; }

    public string ContactPhone { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
}
