using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class StartDateChange
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public int? IdCourse { get; set; }

    public int? ChangedBy { get; set; }

    public DateOnly? PreviousStartDate { get; set; }

    public string Reason { get; set; }

    public DateTime? Created { get; set; }
}
