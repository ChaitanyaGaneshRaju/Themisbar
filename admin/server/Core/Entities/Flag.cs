using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Flag
{
    public int IdFlag { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public bool? Active { get; set; }
}
