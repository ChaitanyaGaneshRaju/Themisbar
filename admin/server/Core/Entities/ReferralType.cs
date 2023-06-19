using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ReferralType
{
    public int IdReferralType { get; set; }

    public string Name { get; set; }

    public int? Seq { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public sbyte Active { get; set; }
}
