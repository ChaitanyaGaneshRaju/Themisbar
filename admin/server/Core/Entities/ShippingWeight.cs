using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ShippingWeight
{
    public int IdCourse { get; set; }

    public decimal? Weight { get; set; }
}
