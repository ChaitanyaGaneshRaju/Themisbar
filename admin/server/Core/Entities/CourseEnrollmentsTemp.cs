using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseEnrollmentsTemp
{
    public int IdReg { get; set; }

    public long IdCourse { get; set; }

    public long IdUser { get; set; }

    public int? IdTuition { get; set; }

    public decimal Balance { get; set; }

    public long IdShippingMethod { get; set; }

    public DateTime ShippingDate { get; set; }

    public bool Shipped { get; set; }

    public bool? ShipBooks { get; set; }

    public DateTime PotentialShippingDate { get; set; }

    public bool GoGreen { get; set; }

    public bool? RegType { get; set; }

    public bool? Access { get; set; }

    public bool Registered { get; set; }

    public bool LaunchOverwrite { get; set; }

    public DateTime LaunchExpirationDate { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public string PassInfo { get; set; }

    public decimal MaxPromo { get; set; }

    public string PaytraceCustomerId { get; set; }
}
