using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// holds all the settings to be controlled on the application
/// </summary>
public partial class Setting
{
    public int Id { get; set; }

    public string SettingKey { get; set; }

    public string SettingValue { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
