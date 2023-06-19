using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DirectorsLawSchool
{
    public long IdUser { get; set; }

    public long IdLawSchool { get; set; }

    public bool Active { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual LawSchool IdLawSchoolNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
