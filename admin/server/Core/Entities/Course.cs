using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

public partial class Course
{
	public long IdCourse { get; set; }

	public DateOnly AvailableStartDate { get; set; }

	public DateOnly AvailableEndDate { get; set; }

	public long IdCourseType { get; set; }

	public long IdOutlineClassification { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public int IdLawSchool { get; set; }

	public string Package { get; set; }

	public bool Enabled { get; set; }

	public DateOnly CourseDate { get; set; }

	public DateOnly RecommendedStartDate { get; set; }

	public bool DisplayFaq { get; set; }

	public bool DisplayMbeBank { get; set; }

	public bool? DisplayUworldMbeQbank { get; set; }

	public sbyte? FlexOnlyOption { get; set; }

	public DateOnly? FlexOnlyEndDate { get; set; }

	public bool Purchasable { get; set; }

	public string WelcomeLetter { get; set; }

	public string ScheduleUrl { get; set; }

	public string ExamName { get; set; }

	public DateOnly ExamDate { get; set; }

	public decimal Price { get; set; }

	public int IdSeason { get; set; }

	public int CourseYear { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool Active { get; set; }

	public virtual ICollection<AdvancedAdminPermission> AdvancedAdminPermissions { get; } = new List<AdvancedAdminPermission>();

	public virtual ICollection<CourseLearnerHoliday> CourseLearnerHolidays { get; } = new List<CourseLearnerHoliday>();

	public virtual ICollection<CourseLearnerTrack> CourseLearnerTracks { get; } = new List<CourseLearnerTrack>();

	public virtual ICollection<CourseSchedule> CourseSchedules { get; } = new List<CourseSchedule>();

	public virtual CourseSetting CourseSetting { get; set; }

	public virtual ICollection<CourseTip> CourseTips { get; } = new List<CourseTip>();

	public virtual ICollection<CoursesAddon> CoursesAddons { get; } = new List<CoursesAddon>();

	public virtual ICollection<CoursesGrader> CoursesGraders { get; } = new List<CoursesGrader>();

	public virtual ICollection<CoursesMcqResult> CoursesMcqResults { get; } = new List<CoursesMcqResult>();

	public virtual ICollection<FlashcardAnswer> FlashcardAnswers { get; } = new List<FlashcardAnswer>();

	public virtual CourseType IdCourseTypeNavigation { get; set; }

	public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

	public virtual ICollection<IntroductionSurveyQuestion> IntroductionSurveyQuestions { get; } = new List<IntroductionSurveyQuestion>();

	public virtual ICollection<LearnerRestDay> LearnerRestDays { get; } = new List<LearnerRestDay>();

	public virtual ICollection<LearnersCourseProgressAward> LearnersCourseProgressAwards { get; } = new List<LearnersCourseProgressAward>();

	public virtual ICollection<McqFeedback> McqFeedbacks { get; } = new List<McqFeedback>();

	public virtual ICollection<McqSetResult> McqSetResults { get; } = new List<McqSetResult>();

	public virtual ICollection<PromosCourse> PromosCourses { get; } = new List<PromosCourse>();

	public virtual ICollection<Task> Tasks { get; } = new List<Task>();

	public virtual ICollection<Track> Tracks { get; } = new List<Track>();

	public virtual ICollection<UserDisengagementEmail> UserDisengagementEmails { get; } = new List<UserDisengagementEmail>();

	public virtual ICollection<Director> IdDirectors { get; } = new List<Director>();

	public virtual ICollection<Invoice> IdInvoices { get; } = new List<Invoice>();
	}
