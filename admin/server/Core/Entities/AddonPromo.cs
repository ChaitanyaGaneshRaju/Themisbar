using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AddonPromo
{
    public long IdPromo { get; set; }

    public int IdAddon { get; set; }

    public string Name { get; set; }

    public virtual Addon IdAddonNavigation { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
