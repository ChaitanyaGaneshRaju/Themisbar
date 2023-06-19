using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnersLawSchool
{
    public long IdUser { get; set; }

    public long IdLawSchool { get; set; }

    public DateOnly GraduationDate { get; set; }

    public int IdProgramType { get; set; }

    public DateOnly? LawSchoolStartDate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual Learner IdUserNavigation { get; set; }
}
