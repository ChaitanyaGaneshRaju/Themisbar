using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class State
{
    public long IdState { get; set; }

    public string Name { get; set; }

    public string Abbreviation { get; set; }

    public long IdCountry { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Country IdCountryNavigation { get; set; }

    public virtual ICollection<LawFirm> LawFirms { get; } = new List<LawFirm>();

    public virtual ICollection<LawSchool> LawSchools { get; } = new List<LawSchool>();
}
