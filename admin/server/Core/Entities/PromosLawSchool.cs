using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromosLawSchool
{
    public long IdPromo { get; set; }

    public long IdLawSchool { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual LawSchool IdLawSchoolNavigation { get; set; }

    public virtual Promo IdPromoNavigation { get; set; }
}
