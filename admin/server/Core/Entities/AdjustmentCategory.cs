using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AdjustmentCategory
{
    public int IdAdjustmentCategory { get; set; }

    public string AdjustmentCategory1 { get; set; }

    public string AdjustmentSubcategory { get; set; }

    public string AdjustmentType { get; set; }

    public bool Billing { get; set; }

    public bool NoRoyalty { get; set; }

    public bool? Active { get; set; }
}
