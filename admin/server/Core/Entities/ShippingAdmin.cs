using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ShippingAdmin
{
    public int IdShippingAdmin { get; set; }

    public string CustomerNumber { get; set; }

    public string FreightAccountNumber { get; set; }

    public string CurrencyValue { get; set; }
}
