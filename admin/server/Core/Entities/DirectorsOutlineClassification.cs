using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DirectorsOutlineClassification
{
    public long IdOutlineClassification { get; set; }

    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public string Active { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
