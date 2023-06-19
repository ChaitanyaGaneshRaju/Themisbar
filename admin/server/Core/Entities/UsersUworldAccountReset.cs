using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsersUworldAccountReset
{
    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public int ResetBy { get; set; }

    public long UworldUserId { get; set; }

    public string UworldHashedPassword { get; set; }
}
