using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaskEvent
{
    public int Id { get; set; }

    public string EventType { get; set; }

    public int IdCourse { get; set; }

    public int IdUser { get; set; }

    public int? IdTask { get; set; }

    public DateOnly EventDate { get; set; }

    public DateOnly UserEventDate { get; set; }

    public bool? EmailSent { get; set; }

    public DateOnly? EmailDate { get; set; }

    public DateTime Created { get; set; }
}
