using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Action
{
    public int IdAction { get; set; }

    public string ActionName { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
