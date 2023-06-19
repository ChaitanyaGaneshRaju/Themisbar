using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Role
{
    public long IdRole { get; set; }

    public string RoleName { get; set; }

    public string Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
