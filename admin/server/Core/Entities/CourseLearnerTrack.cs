using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseLearnerTrack
{
    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public int? IdTrack { get; set; }

    public bool? Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual Track IdTrackNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
