using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// User level permissions
/// </summary>
public partial class PermissionsAreasUser
{
    public long IdArea { get; set; }

    public long IdUser { get; set; }

    public long IdAction { get; set; }

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
