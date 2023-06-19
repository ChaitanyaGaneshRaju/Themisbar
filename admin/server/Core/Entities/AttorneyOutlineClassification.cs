using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AttorneyOutlineClassification
{
    public long IdUser { get; set; }

    public long IdOutlineClassification { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Attorney IdUserNavigation { get; set; }
}
