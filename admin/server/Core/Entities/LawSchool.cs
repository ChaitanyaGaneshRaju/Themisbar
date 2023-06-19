using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LawSchool
{
    public long IdLawSchool { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Website { get; set; }

    public string Otherinfo { get; set; }

    public string Abbreviation { get; set; }

    public string Code { get; set; }

    public long IdState { get; set; }

    public string B2cRegion { get; set; }

    public string B2bRegion { get; set; }

    public sbyte? NoInvoice { get; set; }

    public sbyte? TaxExempt { get; set; }

    public sbyte? Tier { get; set; }

    public string SalesforceId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DirectorsLawSchool> DirectorsLawSchools { get; } = new List<DirectorsLawSchool>();

    public virtual State IdStateNavigation { get; set; }

    public virtual ICollection<PromosLawSchool> PromosLawSchools { get; } = new List<PromosLawSchool>();
}
