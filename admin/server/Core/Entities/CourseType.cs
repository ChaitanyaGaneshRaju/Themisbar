using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseType
{
    public long IdCourseType { get; set; }

    public string Name { get; set; }

    public string SubName { get; set; }

    public string InvoiceDescription { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public bool? OnReports { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<PromosCourseType> PromosCourseTypes { get; } = new List<PromosCourseType>();
}
