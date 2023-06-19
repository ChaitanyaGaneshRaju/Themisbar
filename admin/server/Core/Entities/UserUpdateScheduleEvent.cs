using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UserUpdateScheduleEvent
{
    public long IdUpdateScheduleEvent { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public string StatusCode { get; set; }

    public DateTime CreatedAt { get; set; }
}
