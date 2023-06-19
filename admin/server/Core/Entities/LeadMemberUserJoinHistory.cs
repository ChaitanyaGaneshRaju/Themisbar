using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LeadMemberUserJoinHistory
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? LeadId { get; set; }

    public int MemberId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
