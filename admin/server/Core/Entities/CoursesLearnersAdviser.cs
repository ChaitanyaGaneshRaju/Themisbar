using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CoursesLearnersAdviser
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public long IdAdviser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Adviser IdAdviserNavigation { get; set; }
}
