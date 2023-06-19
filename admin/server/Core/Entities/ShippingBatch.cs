using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ShippingBatch
{
    public long IdBatch { get; set; }

    public long? IdUser { get; set; }

    public DateTime? Created { get; set; }
}
