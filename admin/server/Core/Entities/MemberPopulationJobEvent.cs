using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MemberPopulationJobEvent
{
    public int Id { get; set; }

    public int? NumLeadsAttempted { get; set; }

    public int? NumLeadsProcessed { get; set; }

    public int? LeadIdLowerBound { get; set; }

    public int? LeadIdUpperBound { get; set; }

    public int? NumUnmemberedLeads { get; set; }

    public int? NumMemberedLeads { get; set; }

    public int? NumUsersAttempted { get; set; }

    public int? NumUsersProcessed { get; set; }

    public int? UserIdLowerBound { get; set; }

    public int? UserIdUpperBound { get; set; }

    public int? NumUnmemberedUsers { get; set; }

    public int? NumMemberedUsers { get; set; }

    public DateTime? ExistingRecordsStaleBefore { get; set; }

    public DateTime CreatedAt { get; set; }
}
