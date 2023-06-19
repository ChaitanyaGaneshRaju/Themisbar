using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseScheduleContent
{
    public int Id { get; set; }

    public int IdCourseSchedule { get; set; }

    public DateOnly? ScheduleDate { get; set; }

    public bool? ShowBefore { get; set; }

    public string StyleType { get; set; }

    public string ContentText { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }

    public virtual CourseSchedule IdCourseScheduleNavigation { get; set; }
}
