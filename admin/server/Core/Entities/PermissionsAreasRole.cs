using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// Login type level permissions
/// </summary>
public partial class PermissionsAreasRole
{
    public long IdArea { get; set; }

    public long IdAction { get; set; }

    public long IdRole { get; set; }

    /// <summary>
    /// Permission is granted or not
    /// </summary>
    public bool Granted { get; set; }

    /// <summary>
    /// Date time created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Date time last updated
    /// </summary>
    public DateTime Updated { get; set; }
}
