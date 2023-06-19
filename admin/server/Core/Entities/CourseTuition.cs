using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseTuition
{
    public int IdTuition { get; set; }

    public int IdCourseType { get; set; }

    public int IdCourse { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Tuition { get; set; }

    public decimal? MaxPromo { get; set; }

    public float? MinimumPayment { get; set; }

    public DateTime PaymentDeadline { get; set; }
}
