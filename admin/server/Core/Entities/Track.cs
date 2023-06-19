using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Track
{
    public int Id { get; set; }

    public long? IdCourse { get; set; }

    public string Name { get; set; }

    public string DisplayName { get; set; }

    public int Position { get; set; }

    public DateTime ScheduleStart { get; set; }

    public DateTime ScheduleEnd { get; set; }

    public DateTime RecommendedDisplay { get; set; }

    public DateTime? AccessBegin { get; set; }

    public DateTime? AccessEnd { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CourseLearnerTrack> CourseLearnerTracks { get; } = new List<CourseLearnerTrack>();

    public virtual Course IdCourseNavigation { get; set; }

    public virtual ICollection<TrackSchedule> TrackSchedules { get; } = new List<TrackSchedule>();

    public virtual ICollection<TrackTask> TrackTasks { get; } = new List<TrackTask>();
}
