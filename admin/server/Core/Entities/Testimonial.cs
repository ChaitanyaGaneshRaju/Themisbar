using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Testimonial
{
    public int Id { get; set; }

    public string Quote { get; set; }

    public string Speaker { get; set; }

    public string School { get; set; }

    public string City { get; set; }

    public string UsStateCode { get; set; }

    public string PrimaryHeadshotImagePath { get; set; }

    public int? Weight { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
