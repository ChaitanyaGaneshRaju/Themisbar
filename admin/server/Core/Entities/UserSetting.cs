using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UserSetting
{
    public long IdUser { get; set; }

    public string Attribute { get; set; }

    public string Value { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
