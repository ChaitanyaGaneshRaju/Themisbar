using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class RegistrationType
{
    public int Id { get; set; }

    public string Type { get; set; }

    public bool OnReport { get; set; }
}
