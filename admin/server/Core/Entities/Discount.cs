using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Discount
{
    public int IdDiscount { get; set; }

    public string DiscountCategory { get; set; }

    public string DiscountSubcategory { get; set; }

    public float Amount { get; set; }

    public bool NoRoyalty { get; set; }

    public bool AsPercentage { get; set; }

    public bool? ShipShow { get; set; }

    public bool? ShipBooks { get; set; }

    public sbyte? Active { get; set; }
}
