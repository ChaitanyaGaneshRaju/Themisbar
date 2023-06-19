using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Faculty
{
    public int IdUser { get; set; }

    public bool? AccessClassOverview { get; set; }

    public bool? AccessStudentDetail { get; set; }

    public DateTime? LastLogin { get; set; }
}
