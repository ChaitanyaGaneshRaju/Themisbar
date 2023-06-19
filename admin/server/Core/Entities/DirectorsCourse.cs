using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DirectorsCourse
{
    public int IdDirectorCourse { get; set; }

    public long IdCourse { get; set; }

    public long IdUser { get; set; }

    public long IdUser2 { get; set; }

    public bool? Active { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
