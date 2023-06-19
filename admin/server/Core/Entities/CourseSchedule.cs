using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseSchedule
{
    public int Id { get; set; }

    public long IdCourse { get; set; }

    public string Name { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<CourseScheduleContent> CourseScheduleContents { get; } = new List<CourseScheduleContent>();

    public virtual Course IdCourseNavigation { get; set; }

    public virtual ICollection<TrackSchedule> TrackSchedules { get; } = new List<TrackSchedule>();
}
