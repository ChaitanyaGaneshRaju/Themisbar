using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ResetPassword
{
    public long IdUser { get; set; }

    public string Md5Key { get; set; }

    public DateTime Datetime { get; set; }
}
