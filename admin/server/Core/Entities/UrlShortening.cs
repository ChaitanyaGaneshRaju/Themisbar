using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UrlShortening
{
    public int Id { get; set; }

    public string Url { get; set; }

    public string Description { get; set; }

    public string UtmSource { get; set; }

    public string UtmMedium { get; set; }

    public string UtmTerm { get; set; }

    public string UtmContent { get; set; }

    public string UtmCampaign { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
