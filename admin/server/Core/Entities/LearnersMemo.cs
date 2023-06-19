using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LearnersMemo
{
    public int IdMemo { get; set; }

    public long IdUser { get; set; }

    public long IdReg { get; set; }

    public long IdCourse { get; set; }

    public int Author { get; set; }

    public string Memo { get; set; }

    public long IdFlag { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool? Active { get; set; }
}
