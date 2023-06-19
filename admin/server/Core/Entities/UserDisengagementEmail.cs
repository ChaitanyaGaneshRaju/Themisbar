using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// This table keeps track of disengagement emails sent to user
/// </summary>
public partial class UserDisengagementEmail
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
    /// Course enrollment id
    /// </summary>
    public int IdReg { get; set; }

    /// <summary>
    /// Course Id
    /// </summary>
    public long IdCourse { get; set; }

    /// <summary>
    /// User email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// email content sent
    /// </summary>
    public string EmailContent { get; set; }

    /// <summary>
    /// sent at date
    /// </summary>
    public DateTime SentAt { get; set; }

    /// <summary>
    /// status of the email sent
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// created at
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual CourseEnrollment IdRegNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
