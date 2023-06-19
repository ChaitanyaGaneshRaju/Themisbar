using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsStateArticleLink
{
    public int Id { get; set; }

    public string UsStateCode { get; set; }

    public string Purpose { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public DateTime? ArticlePublishedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
