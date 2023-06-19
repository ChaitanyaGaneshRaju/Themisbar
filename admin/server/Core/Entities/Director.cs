using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Director
{
    public long IdUser { get; set; }

    public string SalesforceId { get; set; }

    public bool? Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual User IdUserNavigation { get; set; }

    public virtual ICollection<Course> IdCourses { get; } = new List<Course>();
}
