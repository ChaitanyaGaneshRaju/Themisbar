using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromosCourseType
{
    public long IdPromo { get; set; }

    public long IdCourseType { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual CourseType IdCourseTypeNavigation { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
