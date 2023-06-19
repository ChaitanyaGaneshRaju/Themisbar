using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class McqSession
{
    public int Id { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public string Name { get; set; }

    public int? RequestedCount { get; set; }

    public DateTime? BeginDatetime { get; set; }
}
