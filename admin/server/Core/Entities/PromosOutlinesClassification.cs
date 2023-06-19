using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromosOutlinesClassification
{
    public long IdPromo { get; set; }

    public long IdOutlineClassification { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
