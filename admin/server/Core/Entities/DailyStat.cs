using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DailyStat
{
    public int Id { get; set; }

    public string Action { get; set; }

    public DateOnly Datetime { get; set; }

    public long IdUser { get; set; }

    public long IdReg { get; set; }

    public bool? RegType { get; set; }

    public long IdCourse { get; set; }

    public int CourseYear { get; set; }

    public long IdCourseType { get; set; }

    public long IdOutlineClassification { get; set; }

    public long IdLawSchool { get; set; }

    public bool Registered { get; set; }

    public bool RegisteredStudent { get; set; }

    public bool Access { get; set; }

    public bool LaunchOverride { get; set; }

    public bool PaidInFull { get; set; }

    public bool FloorMet { get; set; }

    public bool Payment { get; set; }

    public bool PfAbove { get; set; }

    public bool PfBelow { get; set; }

    public bool PfFree { get; set; }

    public bool PartialAbove { get; set; }

    public bool PartialBelow { get; set; }

    public bool UnpaidFirm { get; set; }
}
