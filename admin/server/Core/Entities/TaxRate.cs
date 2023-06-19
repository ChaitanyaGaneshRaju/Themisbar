using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaxRate
{
    public int IdTaxRate { get; set; }

    public int? TaxYear { get; set; }

    public int? IdState { get; set; }

    public int? ZipCode { get; set; }

    public string Country { get; set; }

    public string StateCode { get; set; }

    public decimal Tax { get; set; }

    public bool? OnCourse { get; set; }
}
