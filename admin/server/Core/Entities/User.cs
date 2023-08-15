using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public partial class User : IdentityUser
{
	public long IdUser { get; set; }

	public long? UworldUserId { get; set; }

	public long IdRole { get; set; }

	public int? MemberId { get; set; }

	public string LastName { get; set; }

	public string FirstName { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public string Email { get; set; }

	public string EmailNormalized { get; set; }

	public string AlternateEmail { get; set; }

	public string HomePhone { get; set; }

	public string MobilePhone { get; set; }

	public string AlternatePhone { get; set; }

	public string Username { get; set; }

	public string Password { get; set; }

	public string UworldHashedPassword { get; set; }

	public bool Active { get; set; }

	public string LeadType { get; set; }

	public int? CreatorUserId { get; set; }

	public string EncryptedPassword { get; set; }

	public string ResetPasswordToken { get; set; }

	public DateTime? ResetPasswordSentAt { get; set; }

	public int? IdTimeZone { get; set; }

	public virtual ICollection<AbaRecord> AbaRecords { get; } = new List<AbaRecord>();

	public virtual ICollection<Address> Addresses { get; } = new List<Address>();

	public virtual ICollection<AdvancedAdminPermission> AdvancedAdminPermissions { get; } = new List<AdvancedAdminPermission>();

	public virtual Adviser Adviser { get; set; }

	public virtual Attorney Attorney { get; set; }

	public virtual ICollection<AttorneySubjectOutline> AttorneySubjectOutlines { get; } = new List<AttorneySubjectOutline>();

	public virtual ICollection<CourseLearnerHoliday> CourseLearnerHolidays { get; } = new List<CourseLearnerHoliday>();

	public virtual ICollection<CourseLearnerTrack> CourseLearnerTracks { get; } = new List<CourseLearnerTrack>();

	public virtual ICollection<CourseTipDismissal> CourseTipDismissals { get; } = new List<CourseTipDismissal>();

	public virtual Director Director { get; set; }

	public virtual ICollection<DirectorsLawSchool> DirectorsLawSchools { get; } = new List<DirectorsLawSchool>();

	public virtual ICollection<DirectorsOutlineClassification> DirectorsOutlineClassifications { get; } = new List<DirectorsOutlineClassification>();

	public virtual ICollection<EssayTaskReset> EssayTaskResetIdUserNavigations { get; } = new List<EssayTaskReset>();

	public virtual ICollection<EssayTaskReset> EssayTaskResetResetByNavigations { get; } = new List<EssayTaskReset>();

	public virtual ICollection<ExamAnswerStrikethrough> ExamAnswerStrikethroughs { get; } = new List<ExamAnswerStrikethrough>();

	public virtual ICollection<FlashcardAnswer> FlashcardAnswers { get; } = new List<FlashcardAnswer>();

	public virtual Grader Grader { get; set; }

	public virtual ICollection<IntermittentQuizQuestionResult> IntermittentQuizQuestionResults { get; } = new List<IntermittentQuizQuestionResult>();

	public virtual Learner Learner { get; set; }

	public virtual LearnerDeletion LearnerDeletion { get; set; }

	public virtual ICollection<LearnerRestDay> LearnerRestDays { get; } = new List<LearnerRestDay>();

	public virtual ICollection<LearnersCourseProgressAward> LearnersCourseProgressAwards { get; } = new List<LearnersCourseProgressAward>();

	public virtual ICollection<McqFeedback> McqFeedbacks { get; } = new List<McqFeedback>();

	public virtual ICollection<MessageStatus> MessageStatuses { get; } = new List<MessageStatus>();

	public virtual ICollection<Message> Messages { get; } = new List<Message>();

	public virtual ICollection<ReviewNotification> ReviewNotifications { get; } = new List<ReviewNotification>();

	public virtual ICollection<ReviewResolution> ReviewResolutions { get; } = new List<ReviewResolution>();

	public virtual ICollection<UserDisengagementEmail> UserDisengagementEmails { get; } = new List<UserDisengagementEmail>();

	public virtual ICollection<UserSetting> UserSettings { get; } = new List<UserSetting>();
}
