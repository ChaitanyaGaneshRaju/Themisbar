using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AddonType
{
    public int IdAddonType { get; set; }

    public string Type { get; set; }

    public string AddonType1 { get; set; }

    public string AddonSubtype { get; set; }

    public string FreightCode { get; set; }

    public decimal? Fee { get; set; }

    public bool Tax { get; set; }

    public decimal ToMaxPromo { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool Enabled { get; set; }

    public sbyte? Active { get; set; }
}
