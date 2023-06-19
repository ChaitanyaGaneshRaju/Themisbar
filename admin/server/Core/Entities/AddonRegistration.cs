using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AddonRegistration
{
    public int IdAddon { get; set; }

    public int? IdReg { get; set; }

    public int? IdUser { get; set; }

    public int? IdAddonType { get; set; }

    public decimal? Fee { get; set; }

    public string SerialNumber { get; set; }

    public DateTime ShippingDate { get; set; }

    public string TrackingNumber { get; set; }

    public DateTime Created { get; set; }

    public sbyte? Status { get; set; }
}
