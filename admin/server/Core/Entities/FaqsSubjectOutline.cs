using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class FaqsSubjectOutline
{
    public int IdFaq { get; set; }

    public int IdSubjectOutline { get; set; }

    public virtual Faq IdFaqNavigation { get; set; }
}
