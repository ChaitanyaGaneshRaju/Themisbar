using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Billing
{
    public int IdBilling { get; set; }

    public string Type { get; set; }

    public long IdLawSchool { get; set; }

    public long IdLawFirm { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
