using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromoType
{
    public int IdPromoType { get; set; }

    public string PromoCategory { get; set; }

    public string PromoSubcategory { get; set; }

    public sbyte? Conditional { get; set; }

    public decimal? SuggestedAmount { get; set; }

    public bool AsPercentage { get; set; }

    public decimal? MaxPromoAllowace { get; set; }

    public string Toward { get; set; }

    public sbyte? Active { get; set; }
}
