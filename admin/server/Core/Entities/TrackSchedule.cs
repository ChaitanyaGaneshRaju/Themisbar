using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TrackSchedule
{
    public int IdTrack { get; set; }

    public int IdCourseSchedule { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual CourseSchedule IdCourseScheduleNavigation { get; set; }

    public virtual Track IdTrackNavigation { get; set; }
}
