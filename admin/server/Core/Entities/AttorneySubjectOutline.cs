using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AttorneySubjectOutline
{
    public long IdUser { get; set; }

    public long IdSubjectOutline { get; set; }

    public bool IsPreferred { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
