using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsStateBarExamPricing
{
    public int Id { get; set; }

    public string UsStateCode { get; set; }

    public int? Pos { get; set; }

    public string FilingName { get; set; }

    public DateOnly? FilingDeadline { get; set; }

    public decimal? Price { get; set; }

    public string Qualification { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
