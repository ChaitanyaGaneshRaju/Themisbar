using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Task
{
    public long IdTask { get; set; }

    public long IdCourse { get; set; }

    public DateOnly FixedDate { get; set; }

    public bool Enabled { get; set; }

    public float HoursDuration { get; set; }

    public string TaskType { get; set; }

    public string Name { get; set; }

    public int Position { get; set; }

    public bool ExcludeFromDirected { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    /// <summary>
    /// foreign key for classifications
    /// </summary>
    public long IdOutlineClassification { get; set; }

    public virtual CourseBuilding CourseBuilding { get; set; }

    public virtual ICollection<EssayTaskReset> EssayTaskResets { get; } = new List<EssayTaskReset>();

    public virtual ICollection<ExamAnswerStrikethrough> ExamAnswerStrikethroughs { get; } = new List<ExamAnswerStrikethrough>();

    public virtual Course IdCourseNavigation { get; set; }

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual ICollection<IntermittentQuizQuestionResult> IntermittentQuizQuestionResults { get; } = new List<IntermittentQuizQuestionResult>();

    public virtual TaskSchedule TaskSchedule { get; set; }

    public virtual ICollection<TasksDrill> TasksDrills { get; } = new List<TasksDrill>();

    public virtual ICollection<TasksEssay> TasksEssays { get; } = new List<TasksEssay>();

    public virtual TasksIntermittentQuize TasksIntermittentQuize { get; set; }

    public virtual TasksMilestone TasksMilestone { get; set; }

    public virtual TasksMultipleChoice TasksMultipleChoice { get; set; }

    public virtual TasksPerformanceTest TasksPerformanceTest { get; set; }

    public virtual TasksReview TasksReview { get; set; }

    public virtual ICollection<TasksSubjectOutline> TasksSubjectOutlines { get; } = new List<TasksSubjectOutline>();

    public virtual TasksUworldMbeQbank TasksUworldMbeQbank { get; set; }

    public virtual ICollection<TasksVideo> TasksVideos { get; } = new List<TasksVideo>();

    public virtual ICollection<TrackTask> TrackTasks { get; } = new List<TrackTask>();
}
