using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PassRate
{
    public int Id { get; set; }

    public int? UsStateId { get; set; }

    public int? OurSummer2011PassRates { get; set; }

    public int? PublicSummer2011PassRates { get; set; }

    public int? OurSummer2012PassRates { get; set; }

    public int? PublicSummer2012PassRates { get; set; }

    public int? OurWinter2013PassRates { get; set; }

    public int? PublicWinter2013PassRates { get; set; }

    public int? OurSummer2013PassRates { get; set; }

    public int? PublicSummer2013PassRates { get; set; }

    public int? OurWinter2014PassRates { get; set; }

    public int? PublicWinter2014PassRates { get; set; }

    public int? OurSummer2014PassRates { get; set; }

    public int? OurSummer201475PercentCompletionPassRates { get; set; }

    public int? PublicSummer2014PassRates { get; set; }
}
