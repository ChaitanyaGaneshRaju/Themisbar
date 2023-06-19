using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Section
{
    public long IdSection { get; set; }

    public long IdChapter { get; set; }

    public string Name { get; set; }

    public string TextContent { get; set; }

    public int Position { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AssementQuestion> AssementQuestions { get; } = new List<AssementQuestion>();

    public virtual Chapter IdChapterNavigation { get; set; }

    public virtual ICollection<Question> Questions { get; } = new List<Question>();
}
