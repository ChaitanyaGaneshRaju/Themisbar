using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EulaAcceptanceRecord
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public long IdEula { get; set; }

    public string AreaAccepted { get; set; }

    public DateTime Created { get; set; }
}
