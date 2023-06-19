using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CookieConsent
{
    public int Id { get; set; }

    public string IpAddress { get; set; }

    public string CookieConsentKey { get; set; }

    public DateTime Timestamp { get; set; }
}
