using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MemberActivity
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public string ActivityType { get; set; }

    public string Param1 { get; set; }

    public DateTime ActivityAt { get; set; }

    public DateTime CreatedAt { get; set; }
}
