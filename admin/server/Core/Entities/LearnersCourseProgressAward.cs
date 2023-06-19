using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// This table keeps track of all the awards achieved by the user for a certain course enrollment
/// </summary>
public partial class LearnersCourseProgressAward
{
    /// <summary>
    /// Primary key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// User id
    /// </summary>
    public long IdUser { get; set; }

    /// <summary>
    /// course enrollment id
    /// </summary>
    public int IdReg { get; set; }

    /// <summary>
    /// course id
    /// </summary>
    public long IdCourse { get; set; }

    /// <summary>
    /// task type
    /// </summary>
    public string TaskType { get; set; }

    /// <summary>
    /// total number of tasks available per task type
    /// </summary>
    public int? TotalNumOfTasks { get; set; }

    /// <summary>
    /// total number of tasks completed per task type
    /// </summary>
    public int? CompletedNumOfTasks { get; set; }

    /// <summary>
    /// first completed subject id of the lecture videos
    /// </summary>
    public long? FirstVideoSubjectCompleted { get; set; }

    /// <summary>
    /// are all lecture videos completed ?
    /// </summary>
    public bool? AllVideosCompleted { get; set; }

    /// <summary>
    /// saves the task_id of AQs where the user have scored more than 84 and less than 100% for first time
    /// </summary>
    public long? First85AqId { get; set; }

    /// <summary>
    /// saves the video_id of the AQ exam where the user have scored more than 84 and less than 100% for first time
    /// </summary>
    public long? First85AqVideoId { get; set; }

    /// <summary>
    /// saves the task_id of the AQs where the user have scored 100% for first time
    /// </summary>
    public long? First100AqId { get; set; }

    /// <summary>
    /// saves the video_id of the AQ exam where the user have scored 100% for first time
    /// </summary>
    public long? First100AqVideoId { get; set; }

    /// <summary>
    /// saves the task_id of MCQs where the user have scored more than 54 and less than 60% for first time
    /// </summary>
    public long? First55McqId { get; set; }

    /// <summary>
    /// saves the task_id of MCQs where the user have scored more than 60 and less than 65% for first time
    /// </summary>
    public long? First60McqId { get; set; }

    /// <summary>
    /// saves the task_id of MCQs where the user have scored more than 65 and less than 100% for first time
    /// </summary>
    public long? First65McqId { get; set; }

    /// <summary>
    /// saves the task_id of PEs where the user have scored more than 62% for first time
    /// </summary>
    public long? First62PeId { get; set; }

    /// <summary>
    /// created at
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// updated at
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual CourseEnrollment IdRegNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
