using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DiscountPromo
{
    public long IdPromo { get; set; }

    public string Name { get; set; }

    public decimal? DepositAmount { get; set; }

    public DateOnly? DepositDate { get; set; }

    public bool? BypassFloorPrice { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
