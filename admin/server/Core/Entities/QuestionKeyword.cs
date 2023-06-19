using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class QuestionKeyword
{
    public int Id { get; set; }

    public string KeywordText { get; set; }

    public virtual ICollection<Faq> IdFaqs { get; } = new List<Faq>();
}
