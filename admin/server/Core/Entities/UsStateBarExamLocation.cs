using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsStateBarExamLocation
{
    public int Id { get; set; }

    public string UsStateCode { get; set; }

    public string City { get; set; }

    public string Venue { get; set; }

    public string Address { get; set; }

    public string Url { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
