using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnerRestDay
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public DateOnly? RestDate { get; set; }

    public DateTime? Created { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
