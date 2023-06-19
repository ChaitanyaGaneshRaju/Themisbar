using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AdvancedAdminPermission
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public string Type { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
