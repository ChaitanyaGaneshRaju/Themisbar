using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Grader
{
    public long IdUser { get; set; }

    public bool W9 { get; set; }

    public bool Contract { get; set; }

    public DateOnly? LatestContractExamDate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CoursesGrader> CoursesGraders { get; } = new List<CoursesGrader>();

    public virtual ICollection<CoursesLearnersGrader> CoursesLearnersGraders { get; } = new List<CoursesLearnersGrader>();

    public virtual User IdUserNavigation { get; set; }
}
