using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// This table has the list of all the influencers
/// </summary>
public partial class Influencer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public sbyte Active { get; set; }

    public string Comments { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<InfluencerCode> InfluencerCodes { get; } = new List<InfluencerCode>();
}
