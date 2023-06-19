using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Video
{
    public long IdVideo { get; set; }

    public long IdVideoSet { get; set; }

    public string Name { get; set; }

    public string LecturerName { get; set; }

    public string LecturerInformation { get; set; }

    public bool Enabled { get; set; }

    public string HandoutFilePath { get; set; }

    public int Position { get; set; }

    public sbyte AssessmentQuestionsApprovalCriteria { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AssementQuestion> AssementQuestions { get; } = new List<AssementQuestion>();

    public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; } = new List<AssessmentQuestion>();

    public virtual VideoSet IdVideoSetNavigation { get; set; }

    public virtual ICollection<TasksVideo> TasksVideos { get; } = new List<TasksVideo>();

    public virtual ICollection<VideoLink> VideoLinks { get; } = new List<VideoLink>();
}
