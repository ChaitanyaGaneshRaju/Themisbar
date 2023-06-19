using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Chapter
{
    public long IdChapter { get; set; }

    public long IdSubjectOutline { get; set; }

    public string Title { get; set; }

    public string TextContent { get; set; }

    public int Position { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual SubjectOutline IdSubjectOutlineNavigation { get; set; }

    public virtual ICollection<Section> Sections { get; } = new List<Section>();

    public virtual ICollection<TasksSubjectOutline> TasksSubjectOutlines { get; } = new List<TasksSubjectOutline>();
}
