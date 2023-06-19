using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PromoConditional
{
    public int IdPromoConditional { get; set; }

    public int IdPromoType { get; set; }

    public int? IdCourse { get; set; }

    public int IdCourseType { get; set; }

    public int IdSeason { get; set; }

    public int IdState { get; set; }

    public int IdSchool { get; set; }

    public short Year { get; set; }

    public string Title { get; set; }

    public float Amount { get; set; }

    public DateTime AdvertisementStart { get; set; }

    public DateTime AdvertisementEnd { get; set; }

    public string Advertisement { get; set; }

    public bool ApplyNext { get; set; }

    public bool? Active { get; set; }
}
