using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TransactionsAddon
{
    public int IdTransaction { get; set; }

    public int IdAddon { get; set; }

    public string Subtype { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
