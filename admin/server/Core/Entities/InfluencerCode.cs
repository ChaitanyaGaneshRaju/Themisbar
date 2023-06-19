using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// This table has the list of all codes associated with influencers
/// </summary>
public partial class InfluencerCode
{
    public int Id { get; set; }

    public string Code { get; set; }

    public int IdInfluencer { get; set; }

    public float Amount { get; set; }

    public sbyte IsActive { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public string Comments { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Influencer IdInfluencerNavigation { get; set; }
}
