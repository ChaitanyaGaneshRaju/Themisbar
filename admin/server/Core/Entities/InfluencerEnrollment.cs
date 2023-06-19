using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// This Table gives list of data about Enrollment of users by Influencer
/// </summary>
public partial class InfluencerEnrollment
{
    public int Id { get; set; }

    public long IdReg { get; set; }

    public int? IdTransaction { get; set; }

    public long? IdUser { get; set; }

    public long? IdCourse { get; set; }

    public string InfluencerCode { get; set; }
}
