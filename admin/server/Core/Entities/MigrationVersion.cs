using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MigrationVersion
{
    public string Version { get; set; }

    /// <summary>
    /// (DC2Type:datetime_immutable)
    /// </summary>
    public DateTime ExecutedAt { get; set; }
}
