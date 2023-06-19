using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// System Areas
/// </summary>
public partial class Area
{
    public long IdArea { get; set; }

    /// <summary>
    /// Name of the Area
    /// </summary>
    public string AreaName { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Order this area link is displayed on the navigation bar
    /// </summary>
    public int DisplayOrder { get; set; }

    public string AreaType { get; set; }

    /// <summary>
    /// Date time created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Date time last updated
    /// </summary>
    public DateTime Updated { get; set; }
}
