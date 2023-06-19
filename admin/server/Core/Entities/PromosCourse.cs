using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromosCourse
{
    public long IdPromo { get; set; }

    public long IdCourse { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
