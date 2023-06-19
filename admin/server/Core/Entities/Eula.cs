using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Eula
{
    public int Id { get; set; }

    public int IdCourseType { get; set; }

    public string EulaTitle { get; set; }

    public string EulaContent { get; set; }

    public short EulaVersion { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }
}
