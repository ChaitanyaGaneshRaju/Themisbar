using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Addon
{
    public int IdAddon { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal? Price { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Enabled { get; set; }

    public bool? Active { get; set; }
}
