using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// list of all email types
/// </summary>
public partial class EmailType
{
    public int Id { get; set; }

    public string Type { get; set; }

    public string Name { get; set; }

    public string Subject { get; set; }

    public string Template { get; set; }

    public string ServiceProvider { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
