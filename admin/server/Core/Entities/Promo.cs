using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Promo
{
    public long IdPromo { get; set; }

    public int? IdPromoType { get; set; }

    public int? IdPromoConditional { get; set; }

    public string Type { get; set; }

    public decimal Amount { get; set; }

    public string Code { get; set; }

    public bool IsPercentage { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public string Description { get; set; }

    public virtual ICollection<PromosCourseType> PromosCourseTypes { get; } = new List<PromosCourseType>();

    public virtual ICollection<PromosCourse> PromosCourses { get; } = new List<PromosCourse>();

    public virtual ICollection<PromosLawSchool> PromosLawSchools { get; } = new List<PromosLawSchool>();

    public virtual ICollection<PromosOutlinesClassification> PromosOutlinesClassifications { get; } = new List<PromosOutlinesClassification>();
}
