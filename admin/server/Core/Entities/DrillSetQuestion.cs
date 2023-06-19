using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DrillSetQuestion
{
    public int IdDrillSet { get; set; }

    public int IdDrillQuestion { get; set; }

    public short Position { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
