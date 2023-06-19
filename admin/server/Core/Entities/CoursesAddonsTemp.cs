using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesAddonsTemp
{
    public long IdCourse { get; set; }

    public int IdAddon { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
