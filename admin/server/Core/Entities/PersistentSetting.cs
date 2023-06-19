using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PersistentSetting
{
    public string SettingKey { get; set; }

    public string SettingValue { get; set; }
}
