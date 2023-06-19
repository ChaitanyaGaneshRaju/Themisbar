using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaxByState
{
    public long Id { get; set; }

    public int? IdState { get; set; }

    public string Tuition { get; set; }

    public long? PartialAmount { get; set; }

    public bool? Shipping { get; set; }
}
