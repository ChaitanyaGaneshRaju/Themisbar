using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CourseSetting
{
    public long IdCourse { get; set; }

    public bool? AdminFlashcards { get; set; }

    public bool HideDisplayExam { get; set; }

    public bool HideExamOverview { get; set; }

    public bool HasTracks { get; set; }

    public string TrackPrompt { get; set; }

    public bool HideExamSummary { get; set; }

    public DateTime? Created { get; set; }

    public virtual Course IdCourseNavigation { get; set; }
}
