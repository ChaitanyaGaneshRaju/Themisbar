using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Country
{
    public long IdCountry { get; set; }

    public string Name { get; set; }

    public string Abbreviation { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<State> States { get; } = new List<State>();
}
