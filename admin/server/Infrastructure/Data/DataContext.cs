using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data;

public partial class DataContext : DbContext
{
	public DataContext()
	{
	}

	public DataContext(DbContextOptions<DataContext> options)
		: base(options)
	{
	}

	public virtual DbSet<AbaRecord> AbaRecords { get; set; }

	public virtual DbSet<Core.Entities.Action> Actions { get; set; }

	public virtual DbSet<Addon> Addons { get; set; }

	public virtual DbSet<AddonPromo> AddonPromos { get; set; }

	public virtual DbSet<AddonRegistration> AddonRegistrations { get; set; }

	public virtual DbSet<AddonType> AddonTypes { get; set; }

	public virtual DbSet<Address> Addresses { get; set; }

	public virtual DbSet<AdjustmentCategory> AdjustmentCategories { get; set; }

	public virtual DbSet<AdminFlashcard> AdminFlashcards { get; set; }

	public virtual DbSet<AdminFlashcardStatus> AdminFlashcardStatuses { get; set; }

	public virtual DbSet<AdminMessage> AdminMessages { get; set; }

	public virtual DbSet<AdvancedAdminPermission> AdvancedAdminPermissions { get; set; }

	public virtual DbSet<Adviser> Advisers { get; set; }

	public virtual DbSet<AdvisersOutlineClassification> AdvisersOutlineClassifications { get; set; }

	public virtual DbSet<Answer> Answers { get; set; }

	public virtual DbSet<AnswerStrikethrough> AnswerStrikethroughs { get; set; }

	public virtual DbSet<Area> Areas { get; set; }

	public virtual DbSet<AssementQuestion> AssementQuestions { get; set; }

	public virtual DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }

	public virtual DbSet<AssessmentQuestionsLearner> AssessmentQuestionsLearners { get; set; }

	public virtual DbSet<AssignedResponder> AssignedResponders { get; set; }

	public virtual DbSet<Attorney> Attorneys { get; set; }

	public virtual DbSet<AttorneyAssignment> AttorneyAssignments { get; set; }

	public virtual DbSet<AttorneyAssignmentHistory> AttorneyAssignmentHistories { get; set; }

	public virtual DbSet<AttorneyDailyMaximum> AttorneyDailyMaximums { get; set; }

	public virtual DbSet<AttorneyOutlineClassification> AttorneyOutlineClassifications { get; set; }

	public virtual DbSet<AttorneySubjectOutline> AttorneySubjectOutlines { get; set; }

	public virtual DbSet<AttorneysCourse> AttorneysCourses { get; set; }

	public virtual DbSet<AutoPayTransaction> AutoPayTransactions { get; set; }

	public virtual DbSet<Billing> Billings { get; set; }

	public virtual DbSet<BillingInvoice> BillingInvoices { get; set; }

	public virtual DbSet<BillingInvoiceSnapshot> BillingInvoiceSnapshots { get; set; }

	public virtual DbSet<BillingRequest> BillingRequests { get; set; }

	public virtual DbSet<Bookmark> Bookmarks { get; set; }

	public virtual DbSet<BroadcastMessage> BroadcastMessages { get; set; }

	public virtual DbSet<CampusRep> CampusReps { get; set; }

	public virtual DbSet<CcpQuizAnswer> CcpQuizAnswers { get; set; }

	public virtual DbSet<CcpQuizAttempt> CcpQuizAttempts { get; set; }

	public virtual DbSet<CcpUser> CcpUsers { get; set; }

	public virtual DbSet<Chapter> Chapters { get; set; }

	public virtual DbSet<ConDetrimental> ConDetrimentals { get; set; }

	public virtual DbSet<CookieConsent> CookieConsents { get; set; }

	public virtual DbSet<Country> Countries { get; set; }

	public virtual DbSet<Course> Courses { get; set; }

	public virtual DbSet<CourseBuilding> CourseBuildings { get; set; }

	public virtual DbSet<CourseChoice> CourseChoices { get; set; }

	public virtual DbSet<CourseEnrollment> CourseEnrollments { get; set; }

	public virtual DbSet<CourseEnrollmentTransfer> CourseEnrollmentTransfers { get; set; }

	public virtual DbSet<CourseEnrollmentsOrig> CourseEnrollmentsOrigs { get; set; }

	public virtual DbSet<CourseEnrollmentsTemp> CourseEnrollmentsTemps { get; set; }

	public virtual DbSet<CourseHoliday> CourseHolidays { get; set; }

	public virtual DbSet<CourseLearnerHoliday> CourseLearnerHolidays { get; set; }

	public virtual DbSet<CourseLearnerStatistic> CourseLearnerStatistics { get; set; }

	public virtual DbSet<CourseLearnerTrack> CourseLearnerTracks { get; set; }

	public virtual DbSet<CourseProgressAward> CourseProgressAwards { get; set; }

	public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }

	public virtual DbSet<CourseScheduleContent> CourseScheduleContents { get; set; }

	public virtual DbSet<CourseSetting> CourseSettings { get; set; }

	public virtual DbSet<CourseTip> CourseTips { get; set; }

	public virtual DbSet<CourseTipDismissal> CourseTipDismissals { get; set; }

	public virtual DbSet<CourseTuition> CourseTuitions { get; set; }

	public virtual DbSet<CourseType> CourseTypes { get; set; }

	public virtual DbSet<CoursesAddon> CoursesAddons { get; set; }

	public virtual DbSet<CoursesAddonsTemp> CoursesAddonsTemps { get; set; }

	public virtual DbSet<CoursesFaqSubject> CoursesFaqSubjects { get; set; }

	public virtual DbSet<CoursesGrader> CoursesGraders { get; set; }

	public virtual DbSet<CoursesLearner> CoursesLearners { get; set; }

	public virtual DbSet<CoursesLearnersAdviser> CoursesLearnersAdvisers { get; set; }

	public virtual DbSet<CoursesLearnersGrader> CoursesLearnersGraders { get; set; }

	public virtual DbSet<CoursesMcqResult> CoursesMcqResults { get; set; }

	public virtual DbSet<CoursesSubjectOutline> CoursesSubjectOutlines { get; set; }

	public virtual DbSet<CpaAward> CpaAwards { get; set; }

	public virtual DbSet<DailyStat> DailyStats { get; set; }

	public virtual DbSet<DailyStatsConfig> DailyStatsConfigs { get; set; }

	public virtual DbSet<DbSeed> DbSeeds { get; set; }

	public virtual DbSet<Director> Directors { get; set; }

	public virtual DbSet<DirectorsCourse> DirectorsCourses { get; set; }

	public virtual DbSet<DirectorsLawSchool> DirectorsLawSchools { get; set; }

	public virtual DbSet<DirectorsOutlineClassification> DirectorsOutlineClassifications { get; set; }

	public virtual DbSet<DirectorsPermission> DirectorsPermissions { get; set; }

	public virtual DbSet<Discount> Discounts { get; set; }

	public virtual DbSet<DiscountPromo> DiscountPromos { get; set; }

	public virtual DbSet<DrillQuestion> DrillQuestions { get; set; }

	public virtual DbSet<DrillSet> DrillSets { get; set; }

	public virtual DbSet<DrillSetQuestion> DrillSetQuestions { get; set; }

	public virtual DbSet<EmailType> EmailTypes { get; set; }

	public virtual DbSet<EssayBenchmark> EssayBenchmarks { get; set; }

	public virtual DbSet<EssayBenchmarkCategory> EssayBenchmarkCategories { get; set; }

	public virtual DbSet<EssayIssue> EssayIssues { get; set; }

	public virtual DbSet<EssayIssueConclusion> EssayIssueConclusions { get; set; }

	public virtual DbSet<EssayIssueElement> EssayIssueElements { get; set; }

	public virtual DbSet<EssayTaskReset> EssayTaskResets { get; set; }

	public virtual DbSet<Eula> Eulas { get; set; }

	public virtual DbSet<EulaAcceptanceRecord> EulaAcceptanceRecords { get; set; }

	public virtual DbSet<ExamAnswerStrikethrough> ExamAnswerStrikethroughs { get; set; }

	public virtual DbSet<ExamUserActionsEssay> ExamUserActionsEssays { get; set; }

	public virtual DbSet<ExamUserActionsMcq> ExamUserActionsMcqs { get; set; }

	public virtual DbSet<Faculty> Faculties { get; set; }

	public virtual DbSet<FacultyCourse> FacultyCourses { get; set; }

	public virtual DbSet<FacultyLawSchool> FacultyLawSchools { get; set; }

	public virtual DbSet<FacultyManagedCourse> FacultyManagedCourses { get; set; }

	public virtual DbSet<Faq> Faqs { get; set; }

	public virtual DbSet<FaqsSubjectOutline> FaqsSubjectOutlines { get; set; }

	public virtual DbSet<Flag> Flags { get; set; }

	public virtual DbSet<Flashcard> Flashcards { get; set; }

	public virtual DbSet<FlashcardAnswer> FlashcardAnswers { get; set; }

	public virtual DbSet<GenericTip> GenericTips { get; set; }

	public virtual DbSet<GradedEssayResponse> GradedEssayResponses { get; set; }

	public virtual DbSet<GradedEssayResponseEdit> GradedEssayResponseEdits { get; set; }

	public virtual DbSet<Grader> Graders { get; set; }

	public virtual DbSet<HubspotInfo> HubspotInfos { get; set; }

	public virtual DbSet<Influencer> Influencers { get; set; }

	public virtual DbSet<InfluencerCode> InfluencerCodes { get; set; }

	public virtual DbSet<InfluencerEnrollment> InfluencerEnrollments { get; set; }

	public virtual DbSet<IntermittentQuizQuestionResult> IntermittentQuizQuestionResults { get; set; }

	public virtual DbSet<IntroductionSurveyQuestion> IntroductionSurveyQuestions { get; set; }

	public virtual DbSet<IntroductionSurveyQuestionsLearner> IntroductionSurveyQuestionsLearners { get; set; }

	public virtual DbSet<Invoice> Invoices { get; set; }

	public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }

	public virtual DbSet<LawFirm> LawFirms { get; set; }

	public virtual DbSet<LawSchool> LawSchools { get; set; }

	public virtual DbSet<Lead> Leads { get; set; }

	public virtual DbSet<LeadMemberUserJoin> LeadMemberUserJoins { get; set; }

	public virtual DbSet<LeadMemberUserJoinHistory> LeadMemberUserJoinHistories { get; set; }

	public virtual DbSet<Learner> Learners { get; set; }

	public virtual DbSet<LearnerDeletion> LearnerDeletions { get; set; }

	public virtual DbSet<LearnerMessage> LearnerMessages { get; set; }

	public virtual DbSet<LearnerMessageTypeChange> LearnerMessageTypeChanges { get; set; }

	public virtual DbSet<LearnerRestDay> LearnerRestDays { get; set; }

	public virtual DbSet<LearnersCampusRep> LearnersCampusReps { get; set; }

	public virtual DbSet<LearnersCourseProgressAward> LearnersCourseProgressAwards { get; set; }

	public virtual DbSet<LearnersLawSchool> LearnersLawSchools { get; set; }

	public virtual DbSet<LearnersMemo> LearnersMemos { get; set; }

	public virtual DbSet<LearnersSelfAssessElement> LearnersSelfAssessElements { get; set; }

	public virtual DbSet<LearnersSelfAssessment> LearnersSelfAssessments { get; set; }

	public virtual DbSet<LogEvent> LogEvents { get; set; }

	public virtual DbSet<LogEventType> LogEventTypes { get; set; }

	public virtual DbSet<McqFeedback> McqFeedbacks { get; set; }

	public virtual DbSet<McqSession> McqSessions { get; set; }

	public virtual DbSet<McqSetResult> McqSetResults { get; set; }

	public virtual DbSet<Member> Members { get; set; }

	public virtual DbSet<MemberActivity> MemberActivities { get; set; }

	public virtual DbSet<MemberPopulationJobEvent> MemberPopulationJobEvents { get; set; }

	public virtual DbSet<Message> Messages { get; set; }

	public virtual DbSet<MessageAttachment> MessageAttachments { get; set; }

	public virtual DbSet<MessageDetail> MessageDetails { get; set; }

	public virtual DbSet<MessageRelevantContent> MessageRelevantContents { get; set; }

	public virtual DbSet<MessageStatus> MessageStatuses { get; set; }

	public virtual DbSet<MigrationVersion> MigrationVersions { get; set; }

	public virtual DbSet<MilestoneExam> MilestoneExams { get; set; }

	public virtual DbSet<MilestoneExamTaskAttempt> MilestoneExamTaskAttempts { get; set; }

	public virtual DbSet<MilestoneExamsMultipleChoiceQuestion> MilestoneExamsMultipleChoiceQuestions { get; set; }

	public virtual DbSet<MilestoneQuestionsTasksLearner> MilestoneQuestionsTasksLearners { get; set; }

	public virtual DbSet<MultipleChoiceQuestion> MultipleChoiceQuestions { get; set; }

	public virtual DbSet<MultipleChoiceQuestionsLearner> MultipleChoiceQuestionsLearners { get; set; }

	public virtual DbSet<MultipleChoiceSet> MultipleChoiceSets { get; set; }

	public virtual DbSet<MultipleChoiceSetsMultipleChoiceQuestion> MultipleChoiceSetsMultipleChoiceQuestions { get; set; }

	public virtual DbSet<MultipleChoiceSubjectsUsersAverage> MultipleChoiceSubjectsUsersAverages { get; set; }

	public virtual DbSet<MyLog> MyLogs { get; set; }

	public virtual DbSet<OutlinesClassification> OutlinesClassifications { get; set; }

	public virtual DbSet<OutlinesClassificationsEmail> OutlinesClassificationsEmails { get; set; }

	public virtual DbSet<PassRate> PassRates { get; set; }

	public virtual DbSet<PassRateInquiry> PassRateInquiries { get; set; }

	public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }

	public virtual DbSet<PaymentPlan> PaymentPlans { get; set; }

	public virtual DbSet<PermissionsAreasRole> PermissionsAreasRoles { get; set; }

	public virtual DbSet<PermissionsAreasUser> PermissionsAreasUsers { get; set; }

	public virtual DbSet<PersistentSetting> PersistentSettings { get; set; }

	public virtual DbSet<ProgramType> ProgramTypes { get; set; }

	public virtual DbSet<Promo> Promos { get; set; }

	public virtual DbSet<PromoCondition> PromoConditions { get; set; }

	public virtual DbSet<PromoConditional> PromoConditionals { get; set; }

	public virtual DbSet<PromoType> PromoTypes { get; set; }

	public virtual DbSet<PromosCourse> PromosCourses { get; set; }

	public virtual DbSet<PromosCourseType> PromosCourseTypes { get; set; }

	public virtual DbSet<PromosLawSchool> PromosLawSchools { get; set; }

	public virtual DbSet<PromosOutlinesClassification> PromosOutlinesClassifications { get; set; }

	public virtual DbSet<ProxyLogin> ProxyLogins { get; set; }

	public virtual DbSet<Question> Questions { get; set; }

	public virtual DbSet<QuestionBatch> QuestionBatches { get; set; }

	public virtual DbSet<QuestionDetail> QuestionDetails { get; set; }

	public virtual DbSet<QuestionKeyword> QuestionKeywords { get; set; }

	public virtual DbSet<ReferralType> ReferralTypes { get; set; }

	public virtual DbSet<RefundInfo> RefundInfos { get; set; }

	public virtual DbSet<RegistrationType> RegistrationTypes { get; set; }

	public virtual DbSet<ReplyMessage> ReplyMessages { get; set; }

	public virtual DbSet<ResetPassword> ResetPasswords { get; set; }

	public virtual DbSet<ReviewNotification> ReviewNotifications { get; set; }

	public virtual DbSet<ReviewResolution> ReviewResolutions { get; set; }

	public virtual DbSet<Role> Roles { get; set; }

	public virtual DbSet<SalesforceQueue> SalesforceQueues { get; set; }

	public virtual DbSet<SalesforceSendLog> SalesforceSendLogs { get; set; }

	public virtual DbSet<SalesforceVariable> SalesforceVariables { get; set; }

	public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

	public virtual DbSet<Season> Seasons { get; set; }

	public virtual DbSet<Section> Sections { get; set; }

	public virtual DbSet<SelfAssessmentElement> SelfAssessmentElements { get; set; }

	public virtual DbSet<SelfAssessmentPart> SelfAssessmentParts { get; set; }

	public virtual DbSet<SesBounce> SesBounces { get; set; }

	public virtual DbSet<SesBouncedRecipient> SesBouncedRecipients { get; set; }

	public virtual DbSet<SesComplainedRecipient> SesComplainedRecipients { get; set; }

	public virtual DbSet<SesComplaint> SesComplaints { get; set; }

	public virtual DbSet<SesMail> SesMails { get; set; }

	public virtual DbSet<SesNotification> SesNotifications { get; set; }

	public virtual DbSet<Setting> Settings { get; set; }

	public virtual DbSet<ShippingAdmin> ShippingAdmins { get; set; }

	public virtual DbSet<ShippingBatch> ShippingBatches { get; set; }

	public virtual DbSet<ShippingBatchItem> ShippingBatchItems { get; set; }

	public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

	public virtual DbSet<ShippingWeight> ShippingWeights { get; set; }

	public virtual DbSet<StartDateChange> StartDateChanges { get; set; }

	public virtual DbSet<State> States { get; set; }

	public virtual DbSet<StudentOrganization> StudentOrganizations { get; set; }

	public virtual DbSet<StudentType> StudentTypes { get; set; }

	public virtual DbSet<SubjectOutline> SubjectOutlines { get; set; }

	public virtual DbSet<Core.Entities.Task> Tasks { get; set; }

	public virtual DbSet<TaskEssaysSubjectOutline> TaskEssaysSubjectOutlines { get; set; }

	public virtual DbSet<TaskEvent> TaskEvents { get; set; }

	public virtual DbSet<TaskOverride> TaskOverrides { get; set; }

	public virtual DbSet<TaskSchedule> TaskSchedules { get; set; }

	public virtual DbSet<TaskSettingDefault> TaskSettingDefaults { get; set; }

	public virtual DbSet<TaskTypeTip> TaskTypeTips { get; set; }

	public virtual DbSet<TasksDrill> TasksDrills { get; set; }

	public virtual DbSet<TasksEssay> TasksEssays { get; set; }

	public virtual DbSet<TasksEssaysQuestion> TasksEssaysQuestions { get; set; }

	public virtual DbSet<TasksIntermittentQuize> TasksIntermittentQuizes { get; set; }

	public virtual DbSet<TasksLearner> TasksLearners { get; set; }

	public virtual DbSet<TasksMilestone> TasksMilestones { get; set; }

	public virtual DbSet<TasksMultipleChoice> TasksMultipleChoices { get; set; }

	public virtual DbSet<TasksMultipleChoiceSubject> TasksMultipleChoiceSubjects { get; set; }

	public virtual DbSet<TasksPerformanceTest> TasksPerformanceTests { get; set; }

	public virtual DbSet<TasksReview> TasksReviews { get; set; }

	public virtual DbSet<TasksSubjectOutline> TasksSubjectOutlines { get; set; }

	public virtual DbSet<TasksUworldMbeQbank> TasksUworldMbeQbanks { get; set; }

	public virtual DbSet<TasksVideo> TasksVideos { get; set; }

	public virtual DbSet<TasksVideosLearner> TasksVideosLearners { get; set; }

	public virtual DbSet<TaxByState> TaxByStates { get; set; }

	public virtual DbSet<TaxRate> TaxRates { get; set; }

	public virtual DbSet<Testimonial> Testimonials { get; set; }

	public virtual DbSet<ThemisToUworldMcq> ThemisToUworldMcqs { get; set; }

	public virtual DbSet<Core.Entities.TimeZone> TimeZones { get; set; }

	public virtual DbSet<Track> Tracks { get; set; }

	public virtual DbSet<TrackSchedule> TrackSchedules { get; set; }

	public virtual DbSet<TrackTask> TrackTasks { get; set; }

	public virtual DbSet<Transaction> Transactions { get; set; }

	public virtual DbSet<TransactionsAddon> TransactionsAddons { get; set; }

	public virtual DbSet<TransactionsAffirm> TransactionsAffirms { get; set; }

	public virtual DbSet<TransactionsPaytrace> TransactionsPaytraces { get; set; }

	public virtual DbSet<TransactionsTotal> TransactionsTotals { get; set; }

	public virtual DbSet<TransactionsTotalsAddon> TransactionsTotalsAddons { get; set; }

	public virtual DbSet<UlawEnrollment> UlawEnrollments { get; set; }

	public virtual DbSet<UrlShortening> UrlShortenings { get; set; }

	public virtual DbSet<UsState> UsStates { get; set; }

	public virtual DbSet<UsStateArticleLink> UsStateArticleLinks { get; set; }

	public virtual DbSet<UsStateBarExamLocation> UsStateBarExamLocations { get; set; }

	public virtual DbSet<UsStateBarExamPricing> UsStateBarExamPricings { get; set; }

	public virtual DbSet<UsStateStat> UsStateStats { get; set; }

	public virtual DbSet<User> Users { get; set; }

	public virtual DbSet<UserDisengagementEmail> UserDisengagementEmails { get; set; }

	public virtual DbSet<UserSetting> UserSettings { get; set; }

	public virtual DbSet<UserUpdateScheduleEvent> UserUpdateScheduleEvents { get; set; }

	public virtual DbSet<UsersUworldAccountReset> UsersUworldAccountResets { get; set; }

	public virtual DbSet<UworldQbankStudentAttributeStatistic> UworldQbankStudentAttributeStatistics { get; set; }

	public virtual DbSet<UworldQbankStudentOverallStatistic> UworldQbankStudentOverallStatistics { get; set; }

	public virtual DbSet<Vendor> Vendors { get; set; }

	public virtual DbSet<Video> Videos { get; set; }

	public virtual DbSet<VideoLink> VideoLinks { get; set; }

	public virtual DbSet<VideoSet> VideoSets { get; set; }

	public virtual DbSet<WrittenQuestion> WrittenQuestions { get; set; }

	public virtual DbSet<WrittenQuestionsChapter> WrittenQuestionsChapters { get; set; }

	public virtual DbSet<WrittenQuestionsLearnersBenchmark> WrittenQuestionsLearnersBenchmarks { get; set; }

	public virtual DbSet<WrittenQuestionsSubject> WrittenQuestionsSubjects { get; set; }

	public virtual DbSet<WrittenQuestionsTasksLearner> WrittenQuestionsTasksLearners { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseMySql("server=localhost;port=6033;user=root;password=r00t696;database=titan_development;AllowZeroDateTime=true;ConvertZeroDateTime=true;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.33-mysql"));

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		
		modelBuilder
			.UseCollation("latin1_swedish_ci")
			.HasCharSet("latin1");

		modelBuilder.Entity<AbaRecord>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("aba_records");

			entity.HasIndex(e => e.AbaCourse, "fk_aba_records_aba_course");

			entity.HasIndex(e => e.BarCourse, "fk_aba_records_bar_course");

			entity.HasIndex(e => e.IdUser, "fk_aba_records_id_user");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AbaCourse)
				.HasColumnType("int(11)")
				.HasColumnName("aba_course");
			entity.Property(e => e.AbaNumber)
				.HasColumnType("int(11)")
				.HasColumnName("aba_number");
			entity.Property(e => e.BarCourse)
				.HasColumnType("int(11)")
				.HasColumnName("bar_course");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");

			entity.HasOne(d => d.AbaCourseNavigation).WithMany(p => p.AbaRecordAbaCourseNavigations)
				.HasForeignKey(d => d.AbaCourse)
				.HasConstraintName("fk_aba_records_aba_course");

			entity.HasOne(d => d.BarCourseNavigation).WithMany(p => p.AbaRecordBarCourseNavigations)
				.HasForeignKey(d => d.BarCourse)
				.HasConstraintName("fk_aba_records_bar_course");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AbaRecords)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_aba_records_id_user");
		});

		modelBuilder.Entity<Core.Entities.Action>(entity =>
		{
			entity.HasKey(e => e.IdAction).HasName("PRIMARY");

			entity
				.ToTable("actions")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.ActionName, "action_name").IsUnique();

			entity.Property(e => e.IdAction)
				.HasColumnType("int(11)")
				.HasColumnName("id_action");
			entity.Property(e => e.ActionName)
				.IsRequired()
				.HasMaxLength(100)
				.HasColumnName("action_name");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Addon>(entity =>
		{
			entity.HasKey(e => e.IdAddon).HasName("PRIMARY");

			entity.ToTable("addons");

			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.HasColumnType("text")
				.HasColumnName("description");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Price)
				.HasPrecision(10, 2)
				.HasColumnName("price");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<AddonPromo>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("addon_promos");

			entity.HasIndex(e => e.IdPromo, "fkPromos_addons");

			entity.HasIndex(e => e.IdAddon, "fkPromos_addons_Addons");

			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");

			entity.HasOne(d => d.IdAddonNavigation).WithMany()
				.HasForeignKey(d => d.IdAddon)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("addon_promos_ibfk_2");

			entity.HasOne(d => d.IdPromoNavigation).WithMany()
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("addon_promos_ibfk_1");
		});

		modelBuilder.Entity<AddonRegistration>(entity =>
		{
			entity.HasKey(e => e.IdAddon).HasName("PRIMARY");

			entity.ToTable("addon_registrations");

			entity.HasIndex(e => e.IdAddonType, "index_addon_registrations_on_id_addon_type");

			entity.HasIndex(e => e.IdReg, "index_addon_registrations_on_id_reg");

			entity.HasIndex(e => e.IdUser, "index_addon_registrations_on_id_user");

			entity.HasIndex(e => e.Status, "index_addon_registrations_on_status");

			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Fee)
				.HasPrecision(10, 2)
				.HasColumnName("fee");
			entity.Property(e => e.IdAddonType)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon_type");
			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.SerialNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("serial_number");
			entity.Property(e => e.ShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("shipping_date");
			entity.Property(e => e.Status)
				.HasDefaultValueSql("'1'")
				.HasColumnType("tinyint(4)")
				.HasColumnName("status");
			entity.Property(e => e.TrackingNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("tracking_number");
		});

		modelBuilder.Entity<AddonType>(entity =>
		{
			entity.HasKey(e => e.IdAddonType).HasName("PRIMARY");

			entity.ToTable("addon_types");

			entity.HasIndex(e => e.Enabled, "enabled");

			entity.HasIndex(e => e.Active, "index_addon_types_on_active");

			entity.Property(e => e.IdAddonType)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon_type");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.AddonSubtype)
				.HasMaxLength(255)
				.HasColumnName("addon_subtype");
			entity.Property(e => e.AddonType1)
				.HasMaxLength(255)
				.HasColumnName("addon_type");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("description");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.Fee)
				.HasPrecision(10, 2)
				.HasColumnName("fee");
			entity.Property(e => e.FreightCode)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("freight_code");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Tax).HasColumnName("tax");
			entity.Property(e => e.ToMaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("to_max_promo");
			entity.Property(e => e.Type)
				.HasDefaultValueSql("'addon'")
				.HasColumnType("enum('addon','shipping','tax')")
				.HasColumnName("type");
		});

		modelBuilder.Entity<Address>(entity =>
		{
			entity.HasKey(e => e.IdAddress).HasName("PRIMARY");

			entity
				.ToTable("addresses")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdUser, "fk_shipping_address_learners1");

			entity.Property(e => e.IdAddress)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_address");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Address1)
				.HasMaxLength(255)
				.HasColumnName("address1");
			entity.Property(e => e.Address2)
				.HasMaxLength(255)
				.HasColumnName("address2");
			entity.Property(e => e.City)
				.HasMaxLength(50)
				.HasColumnName("city");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCountry)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_country");
			entity.Property(e => e.IdState)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_state");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasColumnType("enum('primary','shipping')")
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.ZipCode)
				.HasMaxLength(50)
				.HasColumnName("zip_code");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Addresses)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_users_addresses_id_user");
		});

		modelBuilder.Entity<AdjustmentCategory>(entity =>
		{
			entity.HasKey(e => e.IdAdjustmentCategory).HasName("PRIMARY");

			entity.ToTable("adjustment_categories");

			entity.HasIndex(e => e.NoRoyalty, "no_royalty");

			entity.Property(e => e.IdAdjustmentCategory)
				.HasColumnType("int(11)")
				.HasColumnName("id_adjustment_category");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.AdjustmentCategory1)
				.HasMaxLength(255)
				.HasColumnName("adjustment_category");
			entity.Property(e => e.AdjustmentSubcategory)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("adjustment_subcategory");
			entity.Property(e => e.AdjustmentType)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("adjustment_type");
			entity.Property(e => e.Billing).HasColumnName("billing");
			entity.Property(e => e.NoRoyalty).HasColumnName("no_royalty");
		});

		modelBuilder.Entity<AdminFlashcard>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("admin_flashcards");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_admin_flashcards_id_subject_outline");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnswerText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("answer_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.QuestionText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.AdminFlashcards)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_admin_flashcards_id_subject_outline");
		});

		modelBuilder.Entity<AdminFlashcardStatus>(entity =>
		{
			entity.HasKey(e => new { e.IdReg, e.IdFlashcard })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("admin_flashcard_statuses");

			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdFlashcard)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_flashcard");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IsCorrect).HasColumnName("is_correct");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<AdminMessage>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("admin_messages")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Active, "admin_users_messages_active");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled)
				.HasColumnType("tinyint(4)")
				.HasColumnName("enabled");
			entity.Property(e => e.InProgress).HasColumnName("in_progress");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<AdvancedAdminPermission>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("advanced_admin_permissions");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse }, "advanced_admin_permissions_id_user_id_course");

			entity.HasIndex(e => new { e.IdUser, e.Type }, "advanced_admin_permissions_id_user_type");

			entity.HasIndex(e => e.IdCourse, "fk_advanced_admin_permissions_id_course");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Type).HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.AdvancedAdminPermissions)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_advanced_admin_permissions_id_course");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AdvancedAdminPermissions)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_advanced_admin_permissions_id_user");
		});

		modelBuilder.Entity<Adviser>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity
				.ToTable("advisers")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Contract).HasColumnName("contract");
			entity.Property(e => e.ContractExamDate).HasColumnName("contract_exam_date");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.MaxStudentsPerClassification)
				.HasColumnType("int(11)")
				.HasColumnName("max_students_per_classification");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.W9).HasColumnName("w9");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Adviser)
				.HasForeignKey<Adviser>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_advisers_users1");
		});

		modelBuilder.Entity<AdvisersOutlineClassification>(entity =>
		{
			entity.HasKey(e => new { e.IdOutlineClassification, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("advisers_outline_classifications")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdOutlineClassification, "advisers_outline_classifications_id_outline_classification");

			entity.HasIndex(e => e.IdUser, "advisers_outline_classifications_id_user");

			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ExamDate).HasColumnName("exam_date");
			entity.Property(e => e.MaxCount)
				.HasColumnType("int(6)")
				.HasColumnName("max_count");
			entity.Property(e => e.Rate)
				.HasColumnType("int(3)")
				.HasColumnName("rate");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AdvisersOutlineClassifications)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("advisers_outline_classifications_id_user");
		});

		modelBuilder.Entity<Answer>(entity =>
		{
			entity.HasKey(e => e.IdAnswer).HasName("PRIMARY");

			entity.ToTable("answers");

			entity.HasIndex(e => e.Active, "answers_active");

			entity.HasIndex(e => e.IdQuestion, "fk_id_question");

			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.Active)
				.HasColumnType("bigint(20)")
				.HasColumnName("active");
			entity.Property(e => e.AnswerText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("answer_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question");
			entity.Property(e => e.IsCorrect).HasColumnName("is_correct");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.Answers)
				.HasForeignKey(d => d.IdQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_question");
		});

		modelBuilder.Entity<AnswerStrikethrough>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("answer_strikethroughs");

			entity.HasIndex(e => e.IdMultipleChoiceQuestionLearner, "answer_strikethroughs_index_id_mcql");

			entity.HasIndex(e => e.IdAnswer, "fk_answer_strikethroughs_id_answer");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IdMultipleChoiceQuestionLearner)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question_learner");

			entity.HasOne(d => d.IdAnswerNavigation).WithMany(p => p.AnswerStrikethroughs)
				.HasForeignKey(d => d.IdAnswer)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_answer_strikethroughs_id_answer");

			entity.HasOne(d => d.IdMultipleChoiceQuestionLearnerNavigation).WithMany(p => p.AnswerStrikethroughs)
				.HasForeignKey(d => d.IdMultipleChoiceQuestionLearner)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_answer_strikethroughs_id_mcql");
		});

		modelBuilder.Entity<Area>(entity =>
		{
			entity.HasKey(e => e.IdArea).HasName("PRIMARY");

			entity.ToTable("areas", tb => tb.HasComment("System Areas"));

			entity.HasIndex(e => e.AreaName, "area_name").IsUnique();

			entity.Property(e => e.IdArea)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_area");
			entity.Property(e => e.AreaName)
				.IsRequired()
				.HasComment("Name of the Area")
				.HasColumnName("area_name");
			entity.Property(e => e.AreaType)
				.IsRequired()
				.HasColumnType("enum('private','public')")
				.HasColumnName("area_type");
			entity.Property(e => e.Created)
				.HasComment("Date time created")
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasMaxLength(254)
				.HasComment("Description")
				.HasColumnName("description");
			entity.Property(e => e.DisplayOrder)
				.HasComment("Order this area link is displayed on the navigation bar")
				.HasColumnType("int(11)")
				.HasColumnName("display_order");
			entity.Property(e => e.Updated)
				.HasComment("Date time last updated")
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<AssementQuestion>(entity =>
		{
			entity.HasKey(e => e.IdAssessmentQuestion).HasName("PRIMARY");

			entity.ToTable("assement_questions");

			entity.HasIndex(e => e.IdSection, "fk_asssement_questions_sections1");

			entity.HasIndex(e => e.IdVideo, "fk_table1_video1");

			entity.Property(e => e.IdAssessmentQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_assessment_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdSection)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_section");
			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.QuestionStem)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_stem");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSectionNavigation).WithMany(p => p.AssementQuestions)
				.HasForeignKey(d => d.IdSection)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_asssement_questions_sections1");

			entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.AssementQuestions)
				.HasForeignKey(d => d.IdVideo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_table1_video1");
		});

		modelBuilder.Entity<AssessmentQuestion>(entity =>
		{
			entity.HasKey(e => e.IdAssessmentQuestion).HasName("PRIMARY");

			entity.ToTable("assessment_questions");

			entity.HasIndex(e => e.Active, "assessment_questions_active");

			entity.HasIndex(e => e.IdQuestion, "assessment_questions_fk_id_question");

			entity.HasIndex(e => e.IdVideo, "assessment_questions_fk_id_video");

			entity.Property(e => e.IdAssessmentQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_assessment_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question");
			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.IsBaseline)
				.HasDefaultValueSql("'0'")
				.HasColumnName("isBaseline");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.AssessmentQuestions)
				.HasForeignKey(d => d.IdQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("assessment_questions_fk_id_question");

			entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.AssessmentQuestions)
				.HasForeignKey(d => d.IdVideo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("assessment_questions_fk_id_video");
		});

		modelBuilder.Entity<AssessmentQuestionsLearner>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("assessment_questions_learners")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.IdTask, e.IdUser }, "index_assessment_questions_learners_on_id_task_and_id_user");

			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("int(11)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IdAssessmentQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_assessment_question");
			entity.Property(e => e.IdQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_question");
			entity.Property(e => e.IdTask)
				.HasColumnType("int(11)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdVideo)
				.HasColumnType("int(11)")
				.HasColumnName("id_video");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<AssignedResponder>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("assigned_responders", tb => tb.HasComment("this table is needed to avoid having a not null foreign key"))
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Active, "assigned_responders_active");

			entity.HasIndex(e => e.IdUser, "users_id_user");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdUser)
				.HasComment("id of the user assigned to anwer this message")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithOne(p => p.AssignedResponder)
				.HasForeignKey<AssignedResponder>(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_assigned_responders_learner_messages1");
		});

		modelBuilder.Entity<Attorney>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("attorneys");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Available).HasColumnName("available");
			entity.Property(e => e.ContractDate).HasColumnName("contract_date");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Max)
				.HasColumnType("int(11)")
				.HasColumnName("max");
			entity.Property(e => e.PayRatePerQuestion)
				.HasPrecision(10, 2)
				.HasColumnName("pay_rate_per_question");
			entity.Property(e => e.Trusted).HasColumnName("trusted");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.W9).HasColumnName("w9");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Attorney)
				.HasForeignKey<Attorney>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorneys_id_user");
		});

		modelBuilder.Entity<AttorneyAssignment>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity.ToTable("attorney_assignments");

			entity.HasIndex(e => e.IdUser, "index_attorney_assignments_on_id_user");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnsweredDatetime)
				.HasColumnType("datetime")
				.HasColumnName("answered_datetime");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.RevisedDatetime)
				.HasColumnType("datetime")
				.HasColumnName("revised_datetime");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithOne(p => p.AttorneyAssignment)
				.HasForeignKey<AttorneyAssignment>(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorney_assignments_id_message");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AttorneyAssignments)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorney_assignments_id_user");
		});

		modelBuilder.Entity<AttorneyAssignmentHistory>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("attorney_assignment_history");

			entity.HasIndex(e => e.IdUser, "fk_attorneys_attorney_assignment_history_id_user");

			entity.HasIndex(e => e.IdMessage, "fk_messages_attorney_assignment_history_id_message");

			entity.HasIndex(e => e.SubmittedBy, "fk_users_attorney_assignment_history_id_user");

			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.AssignmentAction)
				.HasColumnType("enum('Assigned','Unassigned')")
				.HasColumnName("assignment_action");
			entity.Property(e => e.Comments)
				.HasColumnType("text")
				.HasColumnName("comments");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.SubmittedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("submitted_by");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithMany()
				.HasForeignKey(d => d.IdMessage)
				.HasConstraintName("fk_messages_attorney_assignment_history_id_message");

			entity.HasOne(d => d.IdUserNavigation).WithMany()
				.HasForeignKey(d => d.IdUser)
				.HasConstraintName("fk_attorneys_attorney_assignment_history_id_user");

			entity.HasOne(d => d.SubmittedByNavigation).WithMany()
				.HasForeignKey(d => d.SubmittedBy)
				.HasConstraintName("fk_users_attorney_assignment_history_id_user");
		});

		modelBuilder.Entity<AttorneyDailyMaximum>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.Day })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("attorney_daily_maximums");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Day).HasColumnName("day");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.DailyMax)
				.HasColumnType("int(11)")
				.HasColumnName("daily_max");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AttorneyDailyMaximums)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorney_daily_maximums_id_user");
		});

		modelBuilder.Entity<AttorneyOutlineClassification>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdOutlineClassification })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("attorney_outline_classifications");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AttorneyOutlineClassifications)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorneys_outline_classifications_id_user");
		});

		modelBuilder.Entity<AttorneySubjectOutline>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("attorney_subject_outlines");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_attorney_subject_outlines_id_subject_outline");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IsPreferred).HasColumnName("is_preferred");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.AttorneySubjectOutlines)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorney_subject_outlines_id_subject_outline");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AttorneySubjectOutlines)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_attorney_subject_outlines_id_user");
		});

		modelBuilder.Entity<AttorneysCourse>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("attorneys_courses");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
		});

		modelBuilder.Entity<AutoPayTransaction>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("auto_pay_transactions");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Amount)
				.HasColumnType("int(11)")
				.HasColumnName("amount");
			entity.Property(e => e.BaseTransactionId)
				.HasColumnType("int(11)")
				.HasColumnName("base_transaction_id");
			entity.Property(e => e.CapturedIdTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("captured_id_transaction");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.ErrorCode)
				.HasColumnType("int(11)")
				.HasColumnName("error_code");
			entity.Property(e => e.ErrorMsg)
				.HasColumnType("text")
				.HasColumnName("error_msg");
			entity.Property(e => e.IdCcTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_cc_transaction");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdPaymentInfo)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_info");
			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.IsAuthorized)
				.HasColumnType("tinyint(4)")
				.HasColumnName("is_authorized");
			entity.Property(e => e.IsCaptured)
				.HasColumnType("tinyint(4)")
				.HasColumnName("is_captured");
			entity.Property(e => e.StackTrace)
				.HasColumnType("text")
				.HasColumnName("stack_trace");
			entity.Property(e => e.Success)
				.HasColumnType("tinyint(4)")
				.HasColumnName("success");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
		});

		modelBuilder.Entity<Billing>(entity =>
		{
			entity.HasKey(e => e.IdBilling).HasName("PRIMARY");

			entity.ToTable("billing");

			entity.Property(e => e.IdBilling)
				.HasColumnType("int(11)")
				.HasColumnName("id_billing");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdLawFirm)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_firm");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(6)
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<BillingInvoice>(entity =>
		{
			entity.HasKey(e => e.IdBillingInvoice).HasName("PRIMARY");

			entity.ToTable("billing_invoice");

			entity.HasIndex(e => e.IdBilling, "id_billing");

			entity.HasIndex(e => e.Issued, "issued");

			entity.Property(e => e.IdBillingInvoice)
				.HasColumnType("int(11)")
				.HasColumnName("id_billing_invoice");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Due).HasColumnName("due");
			entity.Property(e => e.IdBilling)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_billing");
			entity.Property(e => e.IdPaymentInfo)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_info");
			entity.Property(e => e.Issued).HasColumnName("issued");
			entity.Property(e => e.Memo)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("memo");
			entity.Property(e => e.Paid).HasColumnName("paid");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<BillingInvoiceSnapshot>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("billing_invoice_snapshots");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdBillingInvoice)
				.HasColumnType("int(11)")
				.HasColumnName("id_billing_invoice");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.Int11PrimaryKey)
				.HasColumnType("int(11)")
				.HasColumnName("int(11) PRIMARY KEY");
			entity.Property(e => e.SaveState)
				.HasColumnType("text")
				.HasColumnName("save_state");
		});

		modelBuilder.Entity<BillingRequest>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("billing_requests");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Address1)
				.HasMaxLength(255)
				.HasColumnName("address_1");
			entity.Property(e => e.Address2)
				.HasMaxLength(255)
				.HasColumnName("address_2");
			entity.Property(e => e.BillingType)
				.HasColumnType("enum('law_firm','school')")
				.HasColumnName("billing_type");
			entity.Property(e => e.City)
				.HasMaxLength(50)
				.HasColumnName("city");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.HasMaxLength(255)
				.HasColumnName("email");
			entity.Property(e => e.ExamDate).HasColumnName("exam_date");
			entity.Property(e => e.FirstName)
				.HasMaxLength(255)
				.HasColumnName("first_name");
			entity.Property(e => e.GraduationDate)
				.HasColumnType("datetime")
				.HasColumnName("graduation_date");
			entity.Property(e => e.IdCountry)
				.HasColumnType("int(11)")
				.HasColumnName("id_country");
			entity.Property(e => e.IdLawFirm)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_firm");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("int(11)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdState)
				.HasColumnType("int(11)")
				.HasColumnName("id_state");
			entity.Property(e => e.LastName)
				.HasMaxLength(255)
				.HasColumnName("last_name");
			entity.Property(e => e.LawFirmContactEmail)
				.HasMaxLength(255)
				.HasColumnName("law_firm_contact_email");
			entity.Property(e => e.LawFirmContactName)
				.HasMaxLength(255)
				.HasColumnName("law_firm_contact_name");
			entity.Property(e => e.LawFirmContactPhone)
				.HasMaxLength(255)
				.HasColumnName("law_firm_contact_phone");
			entity.Property(e => e.LawFirmName)
				.HasMaxLength(255)
				.HasColumnName("law_firm_name");
			entity.Property(e => e.MpreExamDate).HasColumnName("mpre_exam_date");
			entity.Property(e => e.PhoneNumber)
				.HasMaxLength(255)
				.HasColumnName("phone_number");
			entity.Property(e => e.TechPackageOptions).HasColumnName("tech_package_options");
			entity.Property(e => e.WantsMpre).HasColumnName("wants_mpre");
			entity.Property(e => e.WantsTechPackage).HasColumnName("wants_tech_package");
			entity.Property(e => e.ZipCode)
				.HasMaxLength(50)
				.HasColumnName("zip_code");
		});

		modelBuilder.Entity<Bookmark>(entity =>
		{
			entity.HasKey(e => new { e.IdSubject, e.IdSection, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity
				.ToTable("bookmarks")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdSection, "bookmarks_id_section");

			entity.HasIndex(e => e.IdSubject, "bookmarks_id_subject");

			entity.HasIndex(e => e.IdUser, "bookmarks_id_user");

			entity.Property(e => e.IdSubject)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject");
			entity.Property(e => e.IdSection)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_section");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Bookmarks)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("bookmarks_id_user");
		});

		modelBuilder.Entity<BroadcastMessage>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("broadcast_message")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Type, "bc_type");

			entity.HasIndex(e => e.Active, "broadcast_message_active");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedOnAdd()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled)
				.HasColumnType("tinyint(4)")
				.HasColumnName("enabled");
			entity.Property(e => e.IdTrack)
				.HasColumnType("int(11)")
				.HasColumnName("id_track");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasColumnType("enum('Themis Broadcast','Adviser Broadcast')")
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithOne(p => p.BroadcastMessage)
				.HasForeignKey<BroadcastMessage>(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_broadcast_message_messages1");
		});

		modelBuilder.Entity<CampusRep>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity
				.ToTable("campus_reps")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdUser, "active_approved_ids");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Date)
				.HasColumnType("datetime")
				.HasColumnName("date");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IsActive).HasColumnName("is_active");
			entity.Property(e => e.Notes)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("notes");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.CampusRep)
				.HasForeignKey<CampusRep>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_campus_rep_learners1");
		});

		modelBuilder.Entity<CcpQuizAnswer>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("ccp_quiz_answers");

			entity.HasIndex(e => e.IdCcpQuizAttempt, "ccp_quiz_answers_id_ccp_quiz_attempt");

			entity.HasIndex(e => e.IdAnswer, "fk_ccp_quiz_answers_answer");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "fk_ccp_quiz_answers_question");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Correct).HasColumnName("correct");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IdCcpQuizAttempt)
				.HasColumnType("int(11)")
				.HasColumnName("id_ccp_quiz_attempt");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.Skipped).HasColumnName("skipped");

			entity.HasOne(d => d.IdCcpQuizAttemptNavigation).WithMany(p => p.CcpQuizAnswers)
				.HasForeignKey(d => d.IdCcpQuizAttempt)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ccp_quiz_answers_attempt");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.CcpQuizAnswers)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ccp_quiz_answers_question");
		});

		modelBuilder.Entity<CcpQuizAttempt>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("ccp_quiz_attempts");

			entity.HasIndex(e => e.CcpAttemptId, "ccp_quiz_attempts_ccp_attempt_id");

			entity.HasIndex(e => new { e.IdCcpUser, e.IdMultipleChoiceSet, e.CcpAttemptId }, "ccp_quiz_attempts_user_question_attempt");

			entity.HasIndex(e => e.IdMultipleChoiceSet, "fk_ccp_quiz_attempts_id_multiple_choice_set");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CcpAttemptId)
				.HasColumnType("int(11)")
				.HasColumnName("ccp_attempt_id");
			entity.Property(e => e.CompletedOn)
				.HasColumnType("datetime")
				.HasColumnName("completed_on");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCcpUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ccp_user");
			entity.Property(e => e.IdMultipleChoiceSet)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_set");

			entity.HasOne(d => d.IdCcpUserNavigation).WithMany(p => p.CcpQuizAttempts)
				.HasForeignKey(d => d.IdCcpUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ccp_quiz_attempts_id_ccp_user");

			entity.HasOne(d => d.IdMultipleChoiceSetNavigation).WithMany(p => p.CcpQuizAttempts)
				.HasForeignKey(d => d.IdMultipleChoiceSet)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ccp_quiz_attempts_id_multiple_choice_set");
		});

		modelBuilder.Entity<CcpUser>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("ccp_users");

			entity.Property(e => e.Id)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email");
			entity.Property(e => e.FirstName)
				.HasMaxLength(255)
				.HasColumnName("first_name");
			entity.Property(e => e.LastName)
				.HasMaxLength(255)
				.HasColumnName("last_name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Chapter>(entity =>
		{
			entity.HasKey(e => e.IdChapter).HasName("PRIMARY");

			entity.ToTable("chapters");

			entity.HasIndex(e => e.Active, "chapters_active");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_chapters_subject_outlines1");

			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.TextContent)
				.IsRequired()
				.HasColumnType("mediumtext")
				.HasColumnName("text_content");
			entity.Property(e => e.Title)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("title");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.Chapters)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_chapters_subject_outlines1");
		});

		modelBuilder.Entity<ConDetrimental>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("con_detrimental");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AccessFreeLseMaterials).HasColumnName("access_free_lse_materials");
			entity.Property(e => e.AccessFreeMpre).HasColumnName("access_free_mpre");
			entity.Property(e => e.BarExamState)
				.HasMaxLength(25)
				.HasColumnName("bar_exam_state");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.HasMaxLength(254)
				.HasColumnName("email");
			entity.Property(e => e.EnrollInLseMaterials)
				.HasMaxLength(50)
				.HasColumnName("enroll_in_lse_materials");
			entity.Property(e => e.ExamDate)
				.HasMaxLength(50)
				.HasColumnName("exam_date");
			entity.Property(e => e.FirstName)
				.HasMaxLength(254)
				.HasColumnName("first_name");
			entity.Property(e => e.GraduationMonth)
				.HasMaxLength(25)
				.HasColumnName("graduation_month");
			entity.Property(e => e.GraduationYear)
				.HasMaxLength(25)
				.HasColumnName("graduation_year");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.LastName)
				.HasMaxLength(254)
				.HasColumnName("last_name");
			entity.Property(e => e.LawSchoolState)
				.HasMaxLength(25)
				.HasColumnName("law_school_state");
			entity.Property(e => e.MpreDate)
				.HasMaxLength(50)
				.HasColumnName("mpre_date");
		});

		modelBuilder.Entity<CookieConsent>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("cookie_consents");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CookieConsentKey)
				.IsRequired()
				.HasMaxLength(32)
				.HasColumnName("cookie_consent_key");
			entity.Property(e => e.IpAddress)
				.IsRequired()
				.HasMaxLength(25)
				.HasColumnName("ip_address");
			entity.Property(e => e.Timestamp)
				.HasColumnType("datetime")
				.HasColumnName("timestamp");
		});

		modelBuilder.Entity<Country>(entity =>
		{
			entity.HasKey(e => e.IdCountry).HasName("PRIMARY");

			entity
				.ToTable("countries")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdCountry)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_country");
			entity.Property(e => e.Abbreviation)
				.IsRequired()
				.HasMaxLength(8)
				.HasColumnName("abbreviation");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Course>(entity =>
		{
			entity.HasKey(e => e.IdCourse).HasName("PRIMARY");

			entity.ToTable("courses");

			entity.HasIndex(e => e.Active, "courses_active");

			entity.HasIndex(e => e.Name, "courses_name_index");

			entity.HasIndex(e => e.IdCourseType, "id_course_type");

			entity.HasIndex(e => e.IdLawSchool, "id_law_school");

			entity.HasIndex(e => e.IdOutlineClassification, "id_outline_classification");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AvailableEndDate).HasColumnName("available_end_date");
			entity.Property(e => e.AvailableStartDate).HasColumnName("available_start_date");
			entity.Property(e => e.CourseDate).HasColumnName("course_date");
			entity.Property(e => e.CourseYear)
				.HasColumnType("int(4)")
				.HasColumnName("course_year");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("description");
			entity.Property(e => e.DisplayFaq).HasColumnName("display_faq");
			entity.Property(e => e.DisplayMbeBank).HasColumnName("display_mbe_bank");
			entity.Property(e => e.DisplayUworldMbeQbank).HasColumnName("display_uworld_mbe_qbank");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.ExamDate).HasColumnName("exam_date");
			entity.Property(e => e.ExamName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("exam_name");
			entity.Property(e => e.FlexOnlyEndDate).HasColumnName("flex_only_end_date");
			entity.Property(e => e.FlexOnlyOption)
				.HasColumnType("tinyint(4)")
				.HasColumnName("flex_only_option");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdSeason)
				.HasColumnType("int(11)")
				.HasColumnName("id_season");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasColumnName("name");
			entity.Property(e => e.Package)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("package");
			entity.Property(e => e.Price)
				.HasPrecision(10, 2)
				.HasColumnName("price");
			entity.Property(e => e.Purchasable).HasColumnName("purchasable");
			entity.Property(e => e.RecommendedStartDate).HasColumnName("recommended_start_date");
			entity.Property(e => e.ScheduleUrl)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("schedule_url");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.WelcomeLetter)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("welcome_letter");

			entity.HasOne(d => d.IdCourseTypeNavigation).WithMany(p => p.Courses)
				.HasForeignKey(d => d.IdCourseType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_type");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.Courses)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_outline_classification");
		});

		modelBuilder.Entity<CourseBuilding>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("course_building");

			entity.Property(e => e.IdTask)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.ScheduledDate).HasColumnName("scheduled_date");
			entity.Property(e => e.VerifiedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("verified_by");
			entity.Property(e => e.VerifiedOn)
				.HasColumnType("datetime")
				.HasColumnName("verified_on");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.CourseBuilding)
				.HasForeignKey<CourseBuilding>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_task");
		});

		modelBuilder.Entity<CourseChoice>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("course_choices");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(64)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseEnrollment>(entity =>
		{
			entity.HasKey(e => e.IdReg).HasName("PRIMARY");

			entity.ToTable("course_enrollments");

			entity.HasIndex(e => e.IdTuition, "index_course_enrollments_on_id_tuition");

			entity.HasIndex(e => e.ShipBooks, "no_ship");

			entity.HasIndex(e => new { e.IdCourse, e.IdUser }, "old_primary_key").IsUnique();

			entity.HasIndex(e => e.RegType, "reg_type");

			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.Access)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("access");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Balance)
				.HasPrecision(10, 2)
				.HasColumnName("balance");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EnrollmentDate)
				.HasColumnType("datetime")
				.HasColumnName("enrollment_date");
			entity.Property(e => e.GoGreen).HasColumnName("go_green");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdShippingMethod)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_shipping_method");
			entity.Property(e => e.IdTuition)
				.HasColumnType("int(11)")
				.HasColumnName("id_tuition");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.LaunchExpirationDate)
				.HasColumnType("datetime")
				.HasColumnName("launch_expiration_date");
			entity.Property(e => e.LaunchOverwrite).HasColumnName("launch_overwrite");
			entity.Property(e => e.MaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo");
			entity.Property(e => e.PassInfo)
				.HasMaxLength(15)
				.HasColumnName("pass_info");
			entity.Property(e => e.PaytraceCustomerId)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("paytrace_customer_id");
			entity.Property(e => e.PotentialShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("potential_shipping_date");
			entity.Property(e => e.RegType)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("reg_type");
			entity.Property(e => e.Registered).HasColumnName("registered");
			entity.Property(e => e.ShipBooks)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("ship_books");
			entity.Property(e => e.Shipped).HasColumnName("shipped");
			entity.Property(e => e.ShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("shipping_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseEnrollmentTransfer>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("course_enrollment_transfers");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Completed)
				.HasColumnType("datetime")
				.HasColumnName("completed");
			entity.Property(e => e.CreatedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("created_by");
			entity.Property(e => e.IdCourseFrom)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_from");
			entity.Property(e => e.IdCourseTo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_to");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
		});

		modelBuilder.Entity<CourseEnrollmentsOrig>(entity =>
		{
			entity.HasKey(e => e.IdReg).HasName("PRIMARY");

			entity.ToTable("course_enrollments_orig");

			entity.HasIndex(e => e.IdTuition, "index_course_enrollments_on_id_tuition");

			entity.HasIndex(e => e.ShipBooks, "no_ship");

			entity.HasIndex(e => new { e.IdCourse, e.IdUser }, "old_primary_key").IsUnique();

			entity.HasIndex(e => e.RegType, "reg_type");

			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.Access)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("access");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Balance)
				.HasPrecision(10, 2)
				.HasColumnName("balance");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EnrollmentDate)
				.HasColumnType("datetime")
				.HasColumnName("enrollment_date");
			entity.Property(e => e.GoGreen).HasColumnName("go_green");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdShippingMethod)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_shipping_method");
			entity.Property(e => e.IdTuition)
				.HasColumnType("int(11)")
				.HasColumnName("id_tuition");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.LaunchExpirationDate)
				.HasColumnType("datetime")
				.HasColumnName("launch_expiration_date");
			entity.Property(e => e.LaunchOverwrite).HasColumnName("launch_overwrite");
			entity.Property(e => e.MaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo");
			entity.Property(e => e.PassInfo)
				.HasMaxLength(15)
				.HasColumnName("pass_info");
			entity.Property(e => e.PaytraceCustomerId)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("paytrace_customer_id");
			entity.Property(e => e.PotentialShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("potential_shipping_date");
			entity.Property(e => e.RegType)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("reg_type");
			entity.Property(e => e.Registered).HasColumnName("registered");
			entity.Property(e => e.ShipBooks)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("ship_books");
			entity.Property(e => e.Shipped).HasColumnName("shipped");
			entity.Property(e => e.ShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("shipping_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseEnrollmentsTemp>(entity =>
		{
			entity.HasKey(e => e.IdReg).HasName("PRIMARY");

			entity.ToTable("course_enrollments_temp");

			entity.HasIndex(e => e.IdTuition, "index_course_enrollments_on_id_tuition");

			entity.HasIndex(e => e.ShipBooks, "no_ship");

			entity.HasIndex(e => new { e.IdCourse, e.IdUser }, "old_primary_key").IsUnique();

			entity.HasIndex(e => e.RegType, "reg_type");

			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.Access)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("access");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Balance)
				.HasPrecision(10, 2)
				.HasColumnName("balance");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EnrollmentDate)
				.HasColumnType("datetime")
				.HasColumnName("enrollment_date");
			entity.Property(e => e.GoGreen).HasColumnName("go_green");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdShippingMethod)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_shipping_method");
			entity.Property(e => e.IdTuition)
				.HasColumnType("int(11)")
				.HasColumnName("id_tuition");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.LaunchExpirationDate)
				.HasColumnType("datetime")
				.HasColumnName("launch_expiration_date");
			entity.Property(e => e.LaunchOverwrite).HasColumnName("launch_overwrite");
			entity.Property(e => e.MaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo");
			entity.Property(e => e.PassInfo)
				.HasMaxLength(15)
				.HasColumnName("pass_info");
			entity.Property(e => e.PaytraceCustomerId)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("paytrace_customer_id");
			entity.Property(e => e.PotentialShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("potential_shipping_date");
			entity.Property(e => e.RegType)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("reg_type");
			entity.Property(e => e.Registered).HasColumnName("registered");
			entity.Property(e => e.ShipBooks)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("ship_books");
			entity.Property(e => e.Shipped).HasColumnName("shipped");
			entity.Property(e => e.ShippingDate)
				.HasColumnType("datetime")
				.HasColumnName("shipping_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseHoliday>(entity =>
		{
			entity.HasKey(e => e.IdCourseHoliday).HasName("PRIMARY");

			entity
				.ToTable("course_holidays")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.Property(e => e.IdCourseHoliday)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_holiday");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.HolidayDate)
				.HasColumnType("datetime")
				.HasColumnName("holiday_date");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Message)
				.HasColumnType("text")
				.HasColumnName("message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseLearnerHoliday>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse, e.IdCourseHoliday })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("course_learner_holidays");

			entity.HasIndex(e => e.IdCourse, "fk_course_learner_holidays_id_course");

			entity.HasIndex(e => e.IdCourseHoliday, "fk_course_learner_holidays_id_course_holiday");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdCourseHoliday)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_holiday");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.OptOut).HasColumnName("opt_out");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CourseLearnerHolidays)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_learner_holidays_id_course");

			entity.HasOne(d => d.IdCourseHolidayNavigation).WithMany(p => p.CourseLearnerHolidays)
				.HasForeignKey(d => d.IdCourseHoliday)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_learner_holidays_id_course_holiday");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CourseLearnerHolidays)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_learner_holidays_id_user");
		});

		modelBuilder.Entity<CourseLearnerStatistic>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("course_learner_statistics");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.GradedEssaysCompleted)
				.HasColumnType("int(11)")
				.HasColumnName("graded_essays_completed");
			entity.Property(e => e.MbeTotalAnswered)
				.HasColumnType("int(11)")
				.HasColumnName("mbe_total_answered");
			entity.Property(e => e.MbeTotalCorrect)
				.HasColumnType("int(11)")
				.HasColumnName("mbe_total_correct");
			entity.Property(e => e.MbeTotalTime)
				.HasColumnType("int(11)")
				.HasColumnName("mbe_total_time");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CourseLearnerTrack>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("course_learner_tracks")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.IdCourse, "IDX_F9A756F930A9DA54");

			entity.HasIndex(e => e.IdTrack, "IDX_F9A756F93866B996");

			entity.HasIndex(e => e.IdUser, "IDX_F9A756F96B3CA4B");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse }, "course_learner_tracks_cl");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("enabled");
			entity.Property(e => e.IdTrack)
				.HasColumnType("int(11)")
				.HasColumnName("id_track");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CourseLearnerTracks)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_F9A756F930A9DA54");

			entity.HasOne(d => d.IdTrackNavigation).WithMany(p => p.CourseLearnerTracks)
				.HasForeignKey(d => d.IdTrack)
				.HasConstraintName("FK_F9A756F93866B996");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CourseLearnerTracks)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_F9A756F96B3CA4B");
		});

		modelBuilder.Entity<CourseProgressAward>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("course_progress_awards");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AwardBadge)
				.HasColumnType("text")
				.HasColumnName("award_badge");
			entity.Property(e => e.AwardCode)
				.HasColumnType("text")
				.HasColumnName("award_code");
			entity.Property(e => e.AwardDescription)
				.HasColumnType("text")
				.HasColumnName("award_description");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
		});

		modelBuilder.Entity<CourseSchedule>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("course_schedules");

			entity.HasIndex(e => e.IdCourse, "fk_course_schedules_id_course");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CourseSchedules)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_schedules_id_course");
		});

		modelBuilder.Entity<CourseScheduleContent>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("course_schedule_contents");

			entity.HasIndex(e => e.IdCourseSchedule, "fk_course_schedule_contents_id_course_schedule");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.ContentText)
				.HasColumnType("text")
				.HasColumnName("content_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourseSchedule)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_schedule");
			entity.Property(e => e.ScheduleDate).HasColumnName("schedule_date");
			entity.Property(e => e.ShowBefore).HasColumnName("show_before");
			entity.Property(e => e.StyleType)
				.HasMaxLength(64)
				.HasColumnName("style_type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseScheduleNavigation).WithMany(p => p.CourseScheduleContents)
				.HasForeignKey(d => d.IdCourseSchedule)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_schedule_contents_id_course_schedule");
		});

		modelBuilder.Entity<CourseSetting>(entity =>
		{
			entity.HasKey(e => e.IdCourse).HasName("PRIMARY");

			entity.ToTable("course_settings");

			entity.Property(e => e.IdCourse)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.AdminFlashcards).HasColumnName("admin_flashcards");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.HasTracks).HasColumnName("has_tracks");
			entity.Property(e => e.HideDisplayExam).HasColumnName("hide_display_exam");
			entity.Property(e => e.HideExamOverview).HasColumnName("hide_exam_overview");
			entity.Property(e => e.HideExamSummary).HasColumnName("hide_exam_summary");
			entity.Property(e => e.TrackPrompt)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("track_prompt");

			entity.HasOne(d => d.IdCourseNavigation).WithOne(p => p.CourseSetting)
				.HasForeignKey<CourseSetting>(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_course_settings_id_course");
		});

		modelBuilder.Entity<CourseTip>(entity =>
		{
			entity.HasKey(e => e.IdCourseTip).HasName("PRIMARY");

			entity.ToTable("course_tips");

			entity.HasIndex(e => e.IdCourse, "id_course_course_tips");

			entity.Property(e => e.IdCourseTip)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_tip");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(16)
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CourseTips)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_course_tips");
		});

		modelBuilder.Entity<CourseTipDismissal>(entity =>
		{
			entity.HasKey(e => new { e.IdCourseTip, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("course_tip_dismissals");

			entity.HasIndex(e => e.IdUser, "course_tip_dismissals_id_user");

			entity.Property(e => e.IdCourseTip)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_tip");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");

			entity.HasOne(d => d.IdCourseTipNavigation).WithMany(p => p.CourseTipDismissals)
				.HasForeignKey(d => d.IdCourseTip)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_tip_course_tip_dismissals");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CourseTipDismissals)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("course_tip_dismissals_id_user");
		});

		modelBuilder.Entity<CourseTuition>(entity =>
		{
			entity.HasKey(e => e.IdTuition).HasName("PRIMARY");

			entity.ToTable("course_tuitions");

			entity.Property(e => e.IdTuition)
				.HasColumnType("int(11)")
				.HasColumnName("id_tuition");
			entity.Property(e => e.EndDate)
				.HasColumnType("datetime")
				.HasColumnName("end_date");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.MaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo");
			entity.Property(e => e.MinimumPayment).HasColumnName("minimum_payment");
			entity.Property(e => e.PaymentDeadline)
				.HasColumnType("datetime")
				.HasColumnName("payment_deadline");
			entity.Property(e => e.StartDate)
				.HasColumnType("datetime")
				.HasColumnName("start_date");
			entity.Property(e => e.Tuition)
				.HasPrecision(10, 2)
				.HasColumnName("tuition");
		});

		modelBuilder.Entity<CourseType>(entity =>
		{
			entity.HasKey(e => e.IdCourseType).HasName("PRIMARY");

			entity.ToTable("course_types");

			entity.HasIndex(e => e.Active, "course_types_active");

			entity.HasIndex(e => e.OnReports, "on_reports");

			entity.Property(e => e.IdCourseType)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.InvoiceDescription)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("invoice_description");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.OnReports)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("on_reports");
			entity.Property(e => e.SubName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("sub_name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CoursesAddon>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdAddon })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_addons");

			entity.HasIndex(e => e.IdAddon, "fk_courses_addons_id_addon");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CoursesAddons)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_addons_id_course");
		});

		modelBuilder.Entity<CoursesAddonsTemp>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdAddon })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_addons_temp");

			entity.HasIndex(e => e.IdAddon, "fk_courses_addons_id_addon");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<CoursesFaqSubject>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_faq_subjects");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
		});

		modelBuilder.Entity<CoursesGrader>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_graders");

			entity.HasIndex(e => e.IdUser, "fk_courses_graders_id_user");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.MaxCount)
				.HasColumnType("int(11)")
				.HasColumnName("max_count");
			entity.Property(e => e.Rate)
				.HasPrecision(5, 2)
				.HasColumnName("rate");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CoursesGraders)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_graders_id_course");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CoursesGraders)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_graders_id_user");
		});

		modelBuilder.Entity<CoursesLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_learners");

			entity.HasIndex(e => e.Active, "courses_learners_active");

			entity.HasIndex(e => e.FirstLaunch, "first_launch");

			entity.HasIndex(e => e.IdUser, "fk_courses_learners_learners1");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.CourseGuideType)
				.IsRequired()
				.HasColumnType("enum('directed','flex')")
				.HasColumnName("course_guide_type");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.FirstLaunch)
				.HasColumnType("datetime")
				.HasColumnName("first_launch");
			entity.Property(e => e.LastLogin)
				.HasDefaultValueSql("'0000-00-00 00:00:00'")
				.HasColumnType("datetime")
				.HasColumnName("last_login");
			entity.Property(e => e.StartDate)
				.HasColumnType("datetime")
				.HasColumnName("start_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.CoursesLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_learners_learners1");
		});

		modelBuilder.Entity<CoursesLearnersAdviser>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse, e.IdAdviser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity
				.ToTable("courses_learners_advisers")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdAdviser, "courses_learners_advisers_advisers");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse }, "courses_learners_advisers_courses_learners");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdAdviser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_adviser");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdAdviserNavigation).WithMany(p => p.CoursesLearnersAdvisers)
				.HasForeignKey(d => d.IdAdviser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("courses_learners_advisers_advisers");
		});

		modelBuilder.Entity<CoursesLearnersGrader>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_learners_graders");

			entity.HasIndex(e => e.IdGrader, "fk_id_grader");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdGrader)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_grader");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdGraderNavigation).WithMany(p => p.CoursesLearnersGraders)
				.HasForeignKey(d => d.IdGrader)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_grader");
		});

		modelBuilder.Entity<CoursesMcqResult>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdMultipleChoiceQuestion })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_mcq_results");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "index_id_multiple_choice_question");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.Correct)
				.HasColumnType("int(11)")
				.HasColumnName("correct");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Time)
				.HasColumnType("int(11)")
				.HasColumnName("time");
			entity.Property(e => e.Total)
				.HasColumnType("int(11)")
				.HasColumnName("total");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.CoursesMcqResults)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_mcq_results_id_course");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.CoursesMcqResults)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_courses_mcq_results_id_mcq");
		});

		modelBuilder.Entity<CoursesSubjectOutline>(entity =>
		{
			entity.HasKey(e => new { e.IdCourse, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("courses_subject_outlines");

			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
		});

		modelBuilder.Entity<CpaAward>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("cpa_awards");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AwardBadge)
				.HasColumnType("text")
				.HasColumnName("award_badge");
			entity.Property(e => e.AwardCode)
				.HasColumnType("text")
				.HasColumnName("award_code");
			entity.Property(e => e.AwardDescription)
				.HasColumnType("text")
				.HasColumnName("award_description");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
		});

		modelBuilder.Entity<DailyStat>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("daily_stats");

			entity.HasIndex(e => e.Datetime, "datetime");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.IdLawSchool, "id_law_school");

			entity.HasIndex(e => e.IdReg, "id_reg");

			entity.HasIndex(e => e.IdUser, "id_user");

			entity.HasIndex(e => e.Action, "type");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Access).HasColumnName("access");
			entity.Property(e => e.Action)
				.IsRequired()
				.HasMaxLength(15)
				.HasDefaultValueSql("''")
				.HasColumnName("action");
			entity.Property(e => e.CourseYear)
				.HasColumnType("int(11)")
				.HasColumnName("course_year");
			entity.Property(e => e.Datetime).HasColumnName("datetime");
			entity.Property(e => e.FloorMet).HasColumnName("floor_met");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.LaunchOverride).HasColumnName("launch_override");
			entity.Property(e => e.PaidInFull).HasColumnName("paid_in_full");
			entity.Property(e => e.PartialAbove).HasColumnName("partial_above");
			entity.Property(e => e.PartialBelow).HasColumnName("partial_below");
			entity.Property(e => e.Payment).HasColumnName("payment");
			entity.Property(e => e.PfAbove).HasColumnName("pf_above");
			entity.Property(e => e.PfBelow).HasColumnName("pf_below");
			entity.Property(e => e.PfFree).HasColumnName("pf_free");
			entity.Property(e => e.RegType)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("reg_type");
			entity.Property(e => e.Registered).HasColumnName("registered");
			entity.Property(e => e.RegisteredStudent).HasColumnName("registered_student");
			entity.Property(e => e.UnpaidFirm).HasColumnName("unpaid_firm");
		});

		modelBuilder.Entity<DailyStatsConfig>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("daily_stats_config");

			entity.Property(e => e.Body)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("body");
			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.SendEmail)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("send_email");
			entity.Property(e => e.Subject)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("subject");
			entity.Property(e => e.ToAddress)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("to_address");
		});

		modelBuilder.Entity<DbSeed>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("db_seeds")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
		});

		modelBuilder.Entity<Director>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("directors");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.SalesforceId)
				.HasMaxLength(45)
				.HasColumnName("salesforce_id");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Director)
				.HasForeignKey<Director>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_directors_id_user");

			entity.HasMany(d => d.IdCourses).WithMany(p => p.IdDirectors)
				.UsingEntity<Dictionary<string, object>>(
					"DirectorsCourseBuilding",
					r => r.HasOne<Course>().WithMany()
						.HasForeignKey("IdCourse")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_id_course"),
					l => l.HasOne<Director>().WithMany()
						.HasForeignKey("IdDirector")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_id_director"),
					j =>
					{
						j.HasKey("IdDirector", "IdCourse")
							.HasName("PRIMARY")
							.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
						j.ToTable("directors_course_building");
						j.HasIndex(new[] { "IdCourse" }, "fk_id_course");
						j.IndexerProperty<long>("IdDirector")
							.HasColumnType("bigint(20)")
							.HasColumnName("id_director");
						j.IndexerProperty<long>("IdCourse")
							.HasColumnType("bigint(20)")
							.HasColumnName("id_course");
					});
		});

		modelBuilder.Entity<DirectorsCourse>(entity =>
		{
			entity.HasKey(e => e.IdDirectorCourse).HasName("PRIMARY");

			entity.ToTable("directors_courses");

			entity.HasIndex(e => new { e.IdCourse, e.IdUser, e.IdUser2, e.Active }, "id_course");

			entity.Property(e => e.IdDirectorCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_director_course");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdUser2)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user2");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<DirectorsLawSchool>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdLawSchool })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("directors_law_schools");

			entity.HasIndex(e => e.IdLawSchool, "fk_id_law_school");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdLawSchoolNavigation).WithMany(p => p.DirectorsLawSchools)
				.HasForeignKey(d => d.IdLawSchool)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_law_school");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.DirectorsLawSchools)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_user");
		});

		modelBuilder.Entity<DirectorsOutlineClassification>(entity =>
		{
			entity.HasKey(e => new { e.IdOutlineClassification, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("directors_outline_classifications")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdOutlineClassification, "directors_outline_classifications_id_outline_classification");

			entity.HasIndex(e => e.IdUser, "directors_outline_classifications_id_user");

			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasMaxLength(45)
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.DirectorsOutlineClassifications)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("directors_outline_classifications_id_user");
		});

		modelBuilder.Entity<DirectorsPermission>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("directors_permissions")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.IdUser, "index_directors_permissions_on_id_user");

			entity.Property(e => e.CanAnswerSubstantiveQuestions).HasColumnName("can_answer_substantive_questions");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
		});

		modelBuilder.Entity<Discount>(entity =>
		{
			entity.HasKey(e => e.IdDiscount).HasName("PRIMARY");

			entity.ToTable("discounts");

			entity.HasIndex(e => e.Active, "index_discounts_on_active");

			entity.HasIndex(e => e.ShipBooks, "no_ship");

			entity.HasIndex(e => e.ShipShow, "ship_show");

			entity.Property(e => e.IdDiscount)
				.HasColumnType("int(11)")
				.HasColumnName("id_discount");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Amount).HasColumnName("amount");
			entity.Property(e => e.AsPercentage).HasColumnName("as_percentage");
			entity.Property(e => e.DiscountCategory)
				.HasMaxLength(255)
				.HasColumnName("discount_category");
			entity.Property(e => e.DiscountSubcategory)
				.HasMaxLength(255)
				.HasColumnName("discount_subcategory");
			entity.Property(e => e.NoRoyalty).HasColumnName("no_royalty");
			entity.Property(e => e.ShipBooks)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("ship_books");
			entity.Property(e => e.ShipShow)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("ship_show");
		});

		modelBuilder.Entity<DiscountPromo>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("discount_promos");

			entity.HasIndex(e => e.IdPromo, "fkPromos_discounts");

			entity.Property(e => e.BypassFloorPrice)
				.HasDefaultValueSql("'0'")
				.HasColumnName("bypass_floor_price");
			entity.Property(e => e.DepositAmount)
				.HasPrecision(10, 2)
				.HasColumnName("deposit_amount");
			entity.Property(e => e.DepositDate).HasColumnName("deposit_date");
			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");

			entity.HasOne(d => d.IdPromoNavigation).WithMany()
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("discount_promos_ibfk_1");
		});

		modelBuilder.Entity<DrillQuestion>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("drill_questions");

			entity.HasIndex(e => e.IdSubjectOutline, "id_subject_outline_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnswerText)
				.HasColumnType("text")
				.HasColumnName("answer_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.QuestionText)
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.DrillQuestions)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_drill_questions_id_subject_outline");
		});

		modelBuilder.Entity<DrillSet>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("drill_sets");

			entity.HasIndex(e => e.IdOutlineClassification, "id_outline_classification_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.DrillSets)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_drill_sets_id_outline_classification");
		});

		modelBuilder.Entity<DrillSetQuestion>(entity =>
		{
			entity.HasKey(e => new { e.IdDrillSet, e.IdDrillQuestion })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("drill_set_questions");

			entity.Property(e => e.IdDrillSet)
				.HasColumnType("int(11)")
				.HasColumnName("id_drill_set");
			entity.Property(e => e.IdDrillQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_drill_question");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Position)
				.HasColumnType("smallint(6)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<EmailType>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("email_types", tb => tb.HasComment("list of all email types"));

			entity.HasIndex(e => e.ServiceProvider, "email_types_service_provider_index");

			entity.HasIndex(e => e.Type, "email_types_type_unique_index").IsUnique();

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.ServiceProvider)
				.IsRequired()
				.HasColumnType("enum('ses','mailgun')")
				.HasColumnName("service_provider");
			entity.Property(e => e.Subject)
				.HasMaxLength(255)
				.HasColumnName("subject");
			entity.Property(e => e.Template)
				.HasMaxLength(255)
				.HasColumnName("template");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasColumnName("type");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");
		});

		modelBuilder.Entity<EssayBenchmark>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("essay_benchmarks")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.IdEssayBenchmarkCategory)
				.HasMaxLength(255)
				.HasColumnName("id_essay_benchmark_category");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
		});

		modelBuilder.Entity<EssayBenchmarkCategory>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("essay_benchmark_categories")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
		});

		modelBuilder.Entity<EssayIssue>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("essay_issues");

			entity.HasIndex(e => new { e.IdWrittenQuestion, e.Active }, "index_essay_issues_id_written_question_active");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdParentIssue)
				.HasColumnType("int(11)")
				.HasColumnName("id_parent_issue");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IssueText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("issue_text");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.Weight)
				.HasColumnType("tinyint(4)")
				.HasColumnName("weight");

			entity.HasOne(d => d.IdWrittenQuestionNavigation).WithMany(p => p.EssayIssues)
				.HasForeignKey(d => d.IdWrittenQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_issues_id_written_question");
		});

		modelBuilder.Entity<EssayIssueConclusion>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("essay_issue_conclusions");

			entity.HasIndex(e => new { e.IdIssue, e.Active }, "index_essay_issue_conclusions_id_issue_active");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.ConclusionText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("conclusion_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdIssue)
				.HasColumnType("int(11)")
				.HasColumnName("id_issue");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdIssueNavigation).WithMany(p => p.EssayIssueConclusions)
				.HasForeignKey(d => d.IdIssue)
				.HasConstraintName("fk_essay_issue_conclusions_id_issue");
		});

		modelBuilder.Entity<EssayIssueElement>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("essay_issue_elements");

			entity.HasIndex(e => new { e.IdEssayIssue, e.Type, e.Active }, "index_essay_issue_elements_id_essay_issue_type_active");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ElementText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("element_text");
			entity.Property(e => e.IdEssayIssue)
				.HasColumnType("int(11)")
				.HasColumnName("id_essay_issue");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(4)
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdEssayIssueNavigation).WithMany(p => p.EssayIssueElements)
				.HasForeignKey(d => d.IdEssayIssue)
				.HasConstraintName("fk_essay_issue_elements_id_essay_issue");
		});

		modelBuilder.Entity<EssayTaskReset>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("essay_task_resets");

			entity.HasIndex(e => e.IdTask, "fk_essay_task_resets_id_task");

			entity.HasIndex(e => e.IdUser, "fk_essay_task_resets_id_user");

			entity.HasIndex(e => e.IdWrittenQuestion, "fk_essay_task_resets_id_written_question");

			entity.HasIndex(e => e.ResetBy, "fk_essay_task_resets_reset_by");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Answer)
				.HasColumnType("text")
				.HasColumnName("answer");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.Reason)
				.HasMaxLength(250)
				.HasColumnName("reason");
			entity.Property(e => e.ResetBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("reset_by");
			entity.Property(e => e.SubmissionDate).HasColumnName("submission_date");
			entity.Property(e => e.TaskCompletedOn)
				.HasColumnType("datetime")
				.HasColumnName("task_completed_on");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.EssayTaskResets)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_task_resets_id_task");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EssayTaskResetIdUserNavigations)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_task_resets_id_user");

			entity.HasOne(d => d.IdWrittenQuestionNavigation).WithMany(p => p.EssayTaskResets)
				.HasForeignKey(d => d.IdWrittenQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_task_resets_id_written_question");

			entity.HasOne(d => d.ResetByNavigation).WithMany(p => p.EssayTaskResetResetByNavigations)
				.HasForeignKey(d => d.ResetBy)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_task_resets_reset_by");
		});

		modelBuilder.Entity<Eula>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("eulas");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.EulaContent)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("eula_content");
			entity.Property(e => e.EulaTitle)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("eula_title");
			entity.Property(e => e.EulaVersion)
				.HasColumnType("smallint(6)")
				.HasColumnName("eula_version");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_type");
		});

		modelBuilder.Entity<EulaAcceptanceRecord>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdEula })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("eula_acceptance_records");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdEula)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_eula");
			entity.Property(e => e.AreaAccepted)
				.IsRequired()
				.HasMaxLength(20)
				.HasColumnName("area_accepted");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
		});

		modelBuilder.Entity<ExamAnswerStrikethrough>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("exam_answer_strikethroughs");

			entity.HasIndex(e => e.IdAnswer, "fk_exam_answer_strikethroughs_id_answer");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "fk_exam_answer_strikethroughs_id_multiple_choice_question");

			entity.HasIndex(e => e.IdTask, "fk_exam_answer_strikethroughs_id_task");

			entity.HasIndex(e => new { e.IdUser, e.IdTask, e.IdMultipleChoiceQuestion }, "index_exam_answer_strikethroughs_keys");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");

			entity.HasOne(d => d.IdAnswerNavigation).WithMany(p => p.ExamAnswerStrikethroughs)
				.HasForeignKey(d => d.IdAnswer)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_exam_answer_strikethroughs_id_answer");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.ExamAnswerStrikethroughs)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_exam_answer_strikethroughs_id_multiple_choice_question");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.ExamAnswerStrikethroughs)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_exam_answer_strikethroughs_id_task");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ExamAnswerStrikethroughs)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_exam_answer_strikethroughs_id_user");
		});

		modelBuilder.Entity<ExamUserActionsEssay>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("exam_user_actions_essay", tb => tb.HasComment("notes and highlights from essays, graded essays, short answer PQs and written questions will be saved here"));

			entity.HasIndex(e => e.IdUser, "exam_user_actions_essay_user_index");

			entity.HasIndex(e => new { e.IdUser, e.IdTask }, "exam_user_actions_essay_user_task_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Highlights)
				.HasColumnType("text")
				.HasColumnName("highlights");
			entity.Property(e => e.IdTask)
				.HasColumnType("int(11)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
		});

		modelBuilder.Entity<ExamUserActionsMcq>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("exam_user_actions_mcq", tb => tb.HasComment("notes and highlights from mcq, mbe, practice tests and quiz builder will be saved here"));

			entity.HasIndex(e => e.IdUser, "exam_user_actions_mcq_user_index");

			entity.HasIndex(e => new { e.IdUser, e.IdMcqSession }, "exam_user_actions_mcq_user_session_index");

			entity.HasIndex(e => new { e.IdUser, e.IdTask }, "exam_user_actions_mcq_user_task_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Highlights)
				.HasColumnType("text")
				.HasColumnName("highlights");
			entity.Property(e => e.IdMcqSession)
				.HasColumnType("int(11)")
				.HasColumnName("id_mcq_session");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdTask)
				.HasColumnType("int(11)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
		});

		modelBuilder.Entity<Faculty>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("faculty");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.AccessClassOverview).HasColumnName("access_class_overview");
			entity.Property(e => e.AccessStudentDetail).HasColumnName("access_student_detail");
			entity.Property(e => e.LastLogin)
				.HasColumnType("datetime")
				.HasColumnName("last_login");
		});

		modelBuilder.Entity<FacultyCourse>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("faculty_courses");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
						});

		modelBuilder.Entity<FacultyLawSchool>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdLawSchool })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("faculty_law_schools");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
		});

		modelBuilder.Entity<FacultyManagedCourse>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("faculty_managed_courses");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
		});

		modelBuilder.Entity<Faq>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("faqs");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnswerText)
				.HasColumnType("text")
				.HasColumnName("answer_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.CreatedById)
				.HasColumnType("int(11)")
				.HasColumnName("created_by_id");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.QuestionText)
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasMany(d => d.IdQuestionKeywords).WithMany(p => p.IdFaqs)
				.UsingEntity<Dictionary<string, object>>(
					"FaqsQuestionKeyword",
					r => r.HasOne<QuestionKeyword>().WithMany()
						.HasForeignKey("IdQuestionKeyword")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_fqk_qk"),
					l => l.HasOne<Faq>().WithMany()
						.HasForeignKey("IdFaq")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_fqk_f"),
					j =>
					{
						j.HasKey("IdFaq", "IdQuestionKeyword")
							.HasName("PRIMARY")
							.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
						j.ToTable("faqs_question_keywords");
						j.HasIndex(new[] { "IdQuestionKeyword" }, "fk_fqk_qk");
						j.IndexerProperty<int>("IdFaq")
							.HasColumnType("int(11)")
							.HasColumnName("id_faq");
						j.IndexerProperty<int>("IdQuestionKeyword")
							.HasColumnType("int(11)")
							.HasColumnName("id_question_keyword");
					});
		});

		modelBuilder.Entity<FaqsSubjectOutline>(entity =>
		{
			entity.HasKey(e => new { e.IdFaq, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("faqs_subject_outlines");

			entity.Property(e => e.IdFaq)
				.HasColumnType("int(11)")
				.HasColumnName("id_faq");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("int(11)")
				.HasColumnName("id_subject_outline");

			entity.HasOne(d => d.IdFaqNavigation).WithMany(p => p.FaqsSubjectOutlines)
				.HasForeignKey(d => d.IdFaq)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_fso_f");
		});

		modelBuilder.Entity<Flag>(entity =>
		{
			entity.HasKey(e => e.IdFlag).HasName("PRIMARY");

			entity.ToTable("flags");

			entity.Property(e => e.IdFlag)
				.HasColumnType("int(11)")
				.HasColumnName("id_flag");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Image)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("image");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
		});

		modelBuilder.Entity<Flashcard>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("flashcards");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_flashcards_id_subject_outline");

			entity.HasIndex(e => new { e.IdReg, e.IdSubjectOutline }, "flashcards_id_reg_id_subject_outline");

			entity.HasIndex(e => new { e.IdReg, e.IdSubjectOutline, e.Status }, "flashcards_id_reg_id_subject_outline_status");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnswerText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("answer_text");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.QuestionText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.Status)
				.HasMaxLength(16)
				.HasColumnName("status");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdRegNavigation).WithMany(p => p.Flashcards)
				.HasForeignKey(d => d.IdReg)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_flashcards_id_reg");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.Flashcards)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_flashcards_id_subject_outline");
		});

		modelBuilder.Entity<FlashcardAnswer>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("flashcard_answers");

			entity.HasIndex(e => e.IdCourse, "fk_flashcard_answers_id_course");

			entity.HasIndex(e => e.IdUser, "fk_flashcard_answers_id_user");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdFlashcard)
				.HasColumnType("int(11)")
				.HasColumnName("id_flashcard");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Status)
				.HasMaxLength(16)
				.HasColumnName("status");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(32)
				.HasColumnName("type");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.FlashcardAnswers)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_flashcard_answers_id_course");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.FlashcardAnswers)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_flashcard_answers_id_user");
		});

		modelBuilder.Entity<GenericTip>(entity =>
		{
			entity.HasKey(e => e.IdCourseTip).HasName("PRIMARY");

			entity.ToTable("generic_tips");

			entity.Property(e => e.IdCourseTip)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_tip");
			entity.Property(e => e.Body)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("body");
			entity.Property(e => e.Title)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("title");

			entity.HasOne(d => d.IdCourseTipNavigation).WithOne(p => p.GenericTip)
				.HasForeignKey<GenericTip>(d => d.IdCourseTip)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_tip_generic_tips");
		});

		modelBuilder.Entity<GradedEssayResponse>(entity =>
		{
			entity.HasKey(e => new { e.IdWrittenQuestion, e.IdUser, e.IdTask })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity
				.ToTable("graded_essay_responses")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => new { e.IdWrittenQuestion, e.IdUser, e.IdTask }, "fk_graded_answers_written_questions_tasks_learners1");

			entity.HasIndex(e => e.Active, "graded_essay_responses_active");

			entity.HasIndex(e => e.IdTask, "graded_essay_responses_id_task");

			entity.HasIndex(e => e.IdUser, "graded_essay_responses_id_user");

			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnalysisScore)
				.HasColumnType("int(11)")
				.HasColumnName("analysis_score");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.GradingDate).HasColumnName("grading_date");
			entity.Property(e => e.IdAdviser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_adviser");
			entity.Property(e => e.LegalKnowledgeScore)
				.HasColumnType("int(11)")
				.HasColumnName("legal_knowledge_score");
			entity.Property(e => e.OverallScore)
				.HasColumnType("int(11)")
				.HasColumnName("overall_score");
			entity.Property(e => e.Reason)
				.HasMaxLength(255)
				.HasColumnName("reason");
			entity.Property(e => e.Response)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("response");
			entity.Property(e => e.ResponseType)
				.IsRequired()
				.HasDefaultValueSql("'graded'")
				.HasColumnType("enum('graded','ungraded')")
				.HasColumnName("response_type");
			entity.Property(e => e.StructureScore)
				.HasColumnType("int(11)")
				.HasColumnName("structure_score");
			entity.Property(e => e.Submitted).HasColumnName("submitted");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<GradedEssayResponseEdit>(entity =>
		{
			entity.HasKey(e => e.IdGradedEssayResponseEdit).HasName("PRIMARY");

			entity.ToTable("graded_essay_response_edits");

			entity.Property(e => e.IdGradedEssayResponseEdit)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_graded_essay_response_edit");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EditorId)
				.HasColumnType("bigint(20)")
				.HasColumnName("editor_id");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.OrigAnalysisScore)
				.HasColumnType("int(11)")
				.HasColumnName("orig_analysis_score");
			entity.Property(e => e.OrigGraderId)
				.HasColumnType("bigint(20)")
				.HasColumnName("orig_grader_id");
			entity.Property(e => e.OrigLegalKnowledgeScore)
				.HasColumnType("int(11)")
				.HasColumnName("orig_legal_knowledge_score");
			entity.Property(e => e.OrigOverallScore)
				.HasColumnType("int(11)")
				.HasColumnName("orig_overall_score");
			entity.Property(e => e.OrigResponse)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("orig_response");
			entity.Property(e => e.OrigStructureScore)
				.HasColumnType("int(11)")
				.HasColumnName("orig_structure_score");
			entity.Property(e => e.Reason)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("reason");
		});

		modelBuilder.Entity<Grader>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("graders");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Contract).HasColumnName("contract");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.LatestContractExamDate).HasColumnName("latest_contract_exam_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.W9).HasColumnName("w9");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Grader)
				.HasForeignKey<Grader>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_graders_id_user");
		});

		modelBuilder.Entity<HubspotInfo>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("hubspot_infos");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.Vid)
				.HasColumnType("int(11)")
				.HasColumnName("vid");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.HubspotInfo)
				.HasForeignKey<HubspotInfo>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_hubspot_infos_id_user");
		});

		modelBuilder.Entity<Influencer>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("influencers", tb => tb.HasComment("This table has the list of all the influencers"));

			entity.HasIndex(e => e.Email, "influencers_email_uindex").IsUnique();

			entity.HasIndex(e => e.FirstName, "influencers_first_name_index");

			entity.HasIndex(e => e.LastName, "influencers_last_name_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Comments)
				.HasColumnType("text")
				.HasColumnName("comments");
			entity.Property(e => e.CreatedAt)
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.CreatedBy)
				.HasColumnType("int(11)")
				.HasColumnName("created_by");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasColumnName("email");
			entity.Property(e => e.FirstName)
				.IsRequired()
				.HasColumnName("first_name");
			entity.Property(e => e.LastName).HasColumnName("last_name");
			entity.Property(e => e.Phone)
				.HasMaxLength(10)
				.HasColumnName("phone");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");
			entity.Property(e => e.UpdatedBy)
				.HasColumnType("int(11)")
				.HasColumnName("updated_by");
		});

		modelBuilder.Entity<InfluencerCode>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("influencer_codes", tb => tb.HasComment("This table has the list of all codes associated with influencers"));

			entity.HasIndex(e => e.Code, "influencer_codes_code_uindex").IsUnique();

			entity.HasIndex(e => new { e.IdInfluencer, e.Code }, "influencer_codes_id_influencer_code_uindex").IsUnique();

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Amount).HasColumnName("amount");
			entity.Property(e => e.Code)
				.IsRequired()
				.HasMaxLength(25)
				.HasColumnName("code");
			entity.Property(e => e.Comments)
				.HasColumnType("text")
				.HasColumnName("comments");
			entity.Property(e => e.CreatedAt)
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.CreatedBy)
				.HasColumnType("int(11)")
				.HasColumnName("created_by");
			entity.Property(e => e.ExpireDate)
				.HasDefaultValueSql("'0000-00-00 00:00:00'")
				.HasColumnType("timestamp")
				.HasColumnName("expire_date");
			entity.Property(e => e.IdInfluencer)
				.HasColumnType("int(11)")
				.HasColumnName("id_influencer");
			entity.Property(e => e.IsActive)
				.HasColumnType("tinyint(4)")
				.HasColumnName("is_active");
			entity.Property(e => e.StartDate)
				.ValueGeneratedOnAddOrUpdate()
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasColumnType("timestamp")
				.HasColumnName("start_date");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");
			entity.Property(e => e.UpdatedBy)
				.HasColumnType("int(11)")
				.HasColumnName("updated_by");

			entity.HasOne(d => d.IdInfluencerNavigation).WithMany(p => p.InfluencerCodes)
				.HasForeignKey(d => d.IdInfluencer)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("influencer_codes_influencers__fk");
		});

		modelBuilder.Entity<InfluencerEnrollment>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("influencer_enrollments", tb => tb.HasComment("This Table gives list of data about Enrollment of users by Influencer"));

			entity.HasIndex(e => e.InfluencerCode, "influencer_enrollments_influencer_code_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_transaction");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.InfluencerCode)
				.IsRequired()
				.HasMaxLength(25)
				.HasColumnName("influencer_code");
		});

		modelBuilder.Entity<IntermittentQuizQuestionResult>(entity =>
		{
			entity.HasKey(e => new { e.IdAssessmentQuestion, e.IdUser, e.IdTask })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("intermittent_quiz_question_results");

			entity.HasIndex(e => e.IdAnswer, "id_answer");

			entity.HasIndex(e => e.IdAssessmentQuestion, "id_assessment_question");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.IdUser, "id_user");

			entity.Property(e => e.IdAssessmentQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_assessment_question");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IsBaseline).HasColumnName("is_baseline");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdAnswerNavigation).WithMany(p => p.IntermittentQuizQuestionResults)
				.HasForeignKey(d => d.IdAnswer)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_intermittent_quiz_question_results_id_answer");

			entity.HasOne(d => d.IdAssessmentQuestionNavigation).WithMany(p => p.IntermittentQuizQuestionResults)
				.HasForeignKey(d => d.IdAssessmentQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_intermittent_quiz_question_results_id_assessment_question");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.IntermittentQuizQuestionResults)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_intermittent_quiz_question_results_id_task");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.IntermittentQuizQuestionResults)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_intermittent_quiz_question_results_id_user");
		});

		modelBuilder.Entity<IntroductionSurveyQuestion>(entity =>
		{
			entity.HasKey(e => e.IdIntroductionSurveyQuestion).HasName("PRIMARY");

			entity
				.ToTable("introduction_survey_questions")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.Active, "introduction_survey_questions_active");

			entity.Property(e => e.IdIntroductionSurveyQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_introduction_survey_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Multiple1)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_1")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Multiple2)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_2")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Multiple3)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_3")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Multiple4)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_4")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Multiple5)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_5")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Multiple6)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("multiple_6")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.QuestionText)
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.QuestionType)
				.HasColumnType("enum('multiple','written_singleline','written_multiline','checkbox','us_phone','us_date')")
				.HasColumnName("question_type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.IntroductionSurveyQuestions)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_survey_q");
		});

		modelBuilder.Entity<IntroductionSurveyQuestionsLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdIntroductionSurveyQuestion, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("introduction_survey_questions_learners");

			entity.HasIndex(e => e.IdUser, "fk_introduction_survey_questions_learners_learners");

			entity.HasIndex(e => e.Active, "introduction_survey_questions_learners_active");

			entity.Property(e => e.IdIntroductionSurveyQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_introduction_survey_question");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Answer)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("answer");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Multiple1Selected).HasColumnName("multiple_1_selected");
			entity.Property(e => e.Multiple2Selected).HasColumnName("multiple_2_selected");
			entity.Property(e => e.Multiple3Selected).HasColumnName("multiple_3_selected");
			entity.Property(e => e.Multiple4Selected).HasColumnName("multiple_4_selected");
			entity.Property(e => e.Multiple5Selected).HasColumnName("multiple_5_selected");
			entity.Property(e => e.Multiple6Selected).HasColumnName("multiple_6_selected");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.IntroductionSurveyQuestionsLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_introduction_survey_questions_learners_learners");
		});

		modelBuilder.Entity<Invoice>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("invoices");

			entity.HasIndex(e => e.IdVendor, "fk_invoice_id_vendor");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.DueDate).HasColumnName("due_date");
			entity.Property(e => e.IdVendor)
				.HasColumnType("int(11)")
				.HasColumnName("id_vendor");
			entity.Property(e => e.InvoiceDate).HasColumnName("invoice_date");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.PaymentAmount)
				.HasPrecision(10, 2)
				.HasColumnName("payment_amount");
			entity.Property(e => e.PaymentDate).HasColumnName("payment_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdVendorNavigation).WithMany(p => p.Invoices)
				.HasForeignKey(d => d.IdVendor)
				.HasConstraintName("fk_invoice_id_vendor");

			entity.HasMany(d => d.IdCourses).WithMany(p => p.IdInvoices)
				.UsingEntity<Dictionary<string, object>>(
					"InvoicesCourse",
					r => r.HasOne<Course>().WithMany()
						.HasForeignKey("IdCourse")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_invoice_course_id_course"),
					l => l.HasOne<Invoice>().WithMany()
						.HasForeignKey("IdInvoice")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("fk_invoice_course_id_invoice"),
					j =>
					{
						j.HasKey("IdInvoice", "IdCourse")
							.HasName("PRIMARY")
							.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
						j.ToTable("invoices_courses");
						j.HasIndex(new[] { "IdCourse" }, "fk_invoice_course_id_course");
						j.IndexerProperty<int>("IdInvoice")
							.HasColumnType("int(11)")
							.HasColumnName("id_invoice");
						j.IndexerProperty<long>("IdCourse")
							.HasColumnType("bigint(20)")
							.HasColumnName("id_course");
					});
		});

		modelBuilder.Entity<InvoiceItem>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("invoice_items");

			entity.HasIndex(e => e.IdInvoice, "fk_invoice_item_id_invoice");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdInvoice)
				.HasColumnType("int(11)")
				.HasColumnName("id_invoice");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");

			entity.HasOne(d => d.IdInvoiceNavigation).WithMany(p => p.InvoiceItems)
				.HasForeignKey(d => d.IdInvoice)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_invoice_item_id_invoice");
		});

		modelBuilder.Entity<LawFirm>(entity =>
		{
			entity.HasKey(e => e.IdLawFirm).HasName("PRIMARY");

			entity
				.ToTable("law_firms")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdState, "fk_law_firms_id_state");

			entity.Property(e => e.IdLawFirm)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_firm");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.BillingEmail)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("billing_email");
			entity.Property(e => e.BillingFirstName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("billing_first_name");
			entity.Property(e => e.BillingJobTitle)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("billing_job_title");
			entity.Property(e => e.BillingLastName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("billing_last_name");
			entity.Property(e => e.BillingPhone)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("billing_phone");
			entity.Property(e => e.City)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("city");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.HasShippingFee).HasColumnName("has_shipping_fee");
			entity.Property(e => e.HasTechPackage).HasColumnName("has_tech_package");
			entity.Property(e => e.IdState)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_state");
			entity.Property(e => e.InvoicePreferences)
				.HasMaxLength(255)
				.HasColumnName("invoice_preferences");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Notes)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.RecruiterEmail)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("recruiter_email");
			entity.Property(e => e.RecruiterFirstName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("recruiter_first_name");
			entity.Property(e => e.RecruiterJobTitle)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("recruiter_job_title");
			entity.Property(e => e.RecruiterLastName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("recruiter_last_name");
			entity.Property(e => e.RecruiterPhone)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("recruiter_phone");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdStateNavigation).WithMany(p => p.LawFirms)
				.HasForeignKey(d => d.IdState)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_law_firms_id_state");
		});

		modelBuilder.Entity<LawSchool>(entity =>
		{
			entity.HasKey(e => e.IdLawSchool).HasName("PRIMARY");

			entity
				.ToTable("law_schools")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdState, "fk_law_schools_states");

			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Abbreviation)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("abbreviation");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.B2bRegion)
				.HasMaxLength(55)
				.HasColumnName("b2b_region");
			entity.Property(e => e.B2cRegion)
				.HasMaxLength(55)
				.HasColumnName("b2c_region");
			entity.Property(e => e.Code)
				.IsRequired()
				.HasMaxLength(4)
				.IsFixedLength()
				.HasColumnName("code");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdState)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_state");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.NoInvoice)
				.HasColumnType("tinyint(4)")
				.HasColumnName("no_invoice");
			entity.Property(e => e.Otherinfo)
				.IsRequired()
				.HasColumnName("otherinfo");
			entity.Property(e => e.Phone)
				.IsRequired()
				.HasMaxLength(20)
				.HasColumnName("phone");
			entity.Property(e => e.SalesforceId)
				.HasMaxLength(55)
				.HasColumnName("salesforce_id");
			entity.Property(e => e.TaxExempt)
				.HasColumnType("tinyint(4)")
				.HasColumnName("tax_exempt");
			entity.Property(e => e.Tier)
				.HasColumnType("tinyint(4)")
				.HasColumnName("tier");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.Website)
				.IsRequired()
				.HasMaxLength(100)
				.HasColumnName("website");

			entity.HasOne(d => d.IdStateNavigation).WithMany(p => p.LawSchools)
				.HasForeignKey(d => d.IdState)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_law_schools_states");
		});

		modelBuilder.Entity<Lead>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("leads");

			entity.HasIndex(e => e.Email, "leads_email");

			entity.HasIndex(e => e.IdUser, "leads_id_user");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.ContactDate).HasColumnName("contact_date");
			entity.Property(e => e.ContactMethod)
				.HasMaxLength(25)
				.HasColumnName("contact_method");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email");
			entity.Property(e => e.EmploymentInfo)
				.HasMaxLength(64)
				.HasColumnName("employment_info");
			entity.Property(e => e.FirstName)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("first_name");
			entity.Property(e => e.GraduationDate).HasColumnName("graduation_date");
			entity.Property(e => e.IdAssignedRep)
				.HasColumnType("int(11)")
				.HasColumnName("id_assigned_rep");
			entity.Property(e => e.IdCourseChoice)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_choice");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdProgramType)
				.HasColumnType("int(11)")
				.HasColumnName("id_program_type");
			entity.Property(e => e.IdStudentType)
				.HasColumnType("int(11)")
				.HasColumnName("id_student_type");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IsCompetitorRep).HasColumnName("is_competitor_rep");
			entity.Property(e => e.LastName)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("last_name");
			entity.Property(e => e.LeadLevel)
				.HasColumnType("int(11)")
				.HasColumnName("lead_level");
			entity.Property(e => e.MpreTaken).HasColumnName("mpre_taken");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.OnlyBarSupport).HasColumnName("only_bar_support");
			entity.Property(e => e.StudentOrganizations)
				.HasMaxLength(255)
				.HasComment("Organizations involved by the leads")
				.HasColumnName("student_organizations");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<LeadMemberUserJoin>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("lead_member_user_joins")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.LeadId, e.MemberId }, "index_lead_member_user_joins_on_lead_id_and_member_id");

			entity.HasIndex(e => new { e.MemberId, e.UserId }, "index_lead_member_user_joins_on_member_id_and_user_id");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.LeadId)
				.HasColumnType("int(11)")
				.HasColumnName("lead_id");
			entity.Property(e => e.MemberId)
				.HasColumnType("int(11)")
				.HasColumnName("member_id");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UserId)
				.HasColumnType("int(11)")
				.HasColumnName("user_id");
		});

		modelBuilder.Entity<LeadMemberUserJoinHistory>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("lead_member_user_join_histories")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.LeadId, e.MemberId }, "index_lead_member_user_join_histories_on_lead_id_and_member_id");

			entity.HasIndex(e => new { e.MemberId, e.UserId }, "index_lead_member_user_join_histories_on_member_id_and_user_id");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.LeadId)
				.HasColumnType("int(11)")
				.HasColumnName("lead_id");
			entity.Property(e => e.MemberId)
				.HasColumnType("int(11)")
				.HasColumnName("member_id");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UserId)
				.HasColumnType("int(11)")
				.HasColumnName("user_id");
		});

		modelBuilder.Entity<Learner>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("learners");

			entity.HasIndex(e => e.Active, "learners_active");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EulaAccepted).HasColumnName("eula_accepted");
			entity.Property(e => e.IdReferralType)
				.HasColumnType("int(11)")
				.HasColumnName("id_referral_type");
			entity.Property(e => e.IdStudentType)
				.HasColumnType("int(11)")
				.HasColumnName("id_student_type");
			entity.Property(e => e.SignupDate).HasColumnName("signup_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.WelcomeDismissed).HasColumnName("welcome_dismissed");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Learner)
				.HasForeignKey<Learner>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learners_users1");
		});

		modelBuilder.Entity<LearnerDeletion>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("learner_deletions");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.DeletedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("deleted_by");
			entity.Property(e => e.DeletedOn)
				.HasColumnType("datetime")
				.HasColumnName("deleted_on");
			entity.Property(e => e.DuplicateUserId)
				.HasColumnType("bigint(20)")
				.HasColumnName("duplicate_user_id");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.LearnerDeletion)
				.HasForeignKey<LearnerDeletion>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learner_deletions_id_user");
		});

		modelBuilder.Entity<LearnerMessage>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("learner_messages")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Active, "learner_messages_active");

			entity.HasIndex(e => e.AsignedStatus, "learner_messages_assigned_status_index");

			entity.HasIndex(e => e.Type, "learner_messages_type_index");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedOnAdd()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.AsignedStatus)
				.IsRequired()
				.HasColumnType("enum('Answered','Unanswered','Pending')")
				.HasColumnName("asigned_status");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Type)
				.HasColumnType("enum('Adviser Question','Attorney Question','Homework Assignment','Study Strategies','Substantive Law','Study Schedule','Course Navigation Question','Technical Question','Customer Service','Graded Essay')")
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithOne(p => p.LearnerMessage)
				.HasForeignKey<LearnerMessage>(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learner_messages_messages1");
		});

		modelBuilder.Entity<LearnerMessageTypeChange>(entity =>
		{
			entity.HasKey(e => e.IdLearnerMessageTypeChange).HasName("PRIMARY");

			entity.ToTable("learner_message_type_changes");

			entity.HasIndex(e => e.IdMessage, "index_learner_message_type_changes_on_id_message");

			entity.HasIndex(e => e.IdUser, "index_learner_message_type_changes_on_id_user");

			entity.Property(e => e.IdLearnerMessageTypeChange)
				.HasColumnType("int(11)")
				.HasColumnName("id_learner_message_type_change");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.NewType)
				.IsRequired()
				.HasMaxLength(40)
				.HasColumnName("new_type");
			entity.Property(e => e.OldType)
				.IsRequired()
				.HasMaxLength(40)
				.HasColumnName("old_type");
		});

		modelBuilder.Entity<LearnerRestDay>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("learner_rest_days");

			entity.HasIndex(e => e.IdCourse, "fk_learner_rest_days_id_course");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse }, "rest_days_id_user_id_course");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.RestDate).HasColumnName("rest_date");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.LearnerRestDays)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learner_rest_days_id_course");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.LearnerRestDays)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learner_rest_days_id_user");
		});

		modelBuilder.Entity<LearnersCampusRep>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdCampusRep })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("learners_campus_reps")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCampusRep, "fk_learners_campus_reps_id_campus_rep");

			entity.HasIndex(e => e.IdUser, "fk_learners_campus_reps_id_user");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdCampusRep)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_campus_rep");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCampusRepNavigation).WithMany(p => p.LearnersCampusReps)
				.HasForeignKey(d => d.IdCampusRep)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learners_campus_reps_id_campus_rep");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.LearnersCampusReps)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learners_campus_reps_id_user");
		});

		modelBuilder.Entity<LearnersCourseProgressAward>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("learners_course_progress_awards", tb => tb.HasComment("This table keeps track of all the awards achieved by the user for a certain course enrollment"));

			entity.HasIndex(e => e.First100AqId, "index_first_100_aq_id_cpa");

			entity.HasIndex(e => e.First55McqId, "index_first_55_mcq_id_cpa");

			entity.HasIndex(e => e.First60McqId, "index_first_60_mcq_id_cpa");

			entity.HasIndex(e => e.First62PeId, "index_first_62_pe_id_cpa");

			entity.HasIndex(e => e.First65McqId, "index_first_65_mcq_id_cpa");

			entity.HasIndex(e => e.First85AqId, "index_first_85_aq_id_cpa");

			entity.HasIndex(e => e.IdCourse, "index_id_course_cpa");

			entity.HasIndex(e => e.Id, "index_id_cpa_unique").IsUnique();

			entity.HasIndex(e => new { e.IdReg, e.TaskType }, "index_id_reg_task_type_cpa_unique").IsUnique();

			entity.HasIndex(e => e.IdUser, "index_id_user_cpa");

			entity.Property(e => e.Id)
				.HasComment("Primary key")
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AllVideosCompleted)
				.HasComment("are all lecture videos completed ?")
				.HasColumnName("all_videos_completed");
			entity.Property(e => e.CompletedNumOfTasks)
				.HasComment("total number of tasks completed per task type")
				.HasColumnType("int(11)")
				.HasColumnName("completed_num_of_tasks");
			entity.Property(e => e.CreatedAt)
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasComment("created at")
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.First100AqId)
				.HasComment("saves the task_id of the AQs where the user have scored 100% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_100_aq_id");
			entity.Property(e => e.First100AqVideoId)
				.HasComment("saves the video_id of the AQ exam where the user have scored 100% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_100_aq_video_id");
			entity.Property(e => e.First55McqId)
				.HasComment("saves the task_id of MCQs where the user have scored more than 54 and less than 60% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_55_mcq_id");
			entity.Property(e => e.First60McqId)
				.HasComment("saves the task_id of MCQs where the user have scored more than 60 and less than 65% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_60_mcq_id");
			entity.Property(e => e.First62PeId)
				.HasComment("saves the task_id of PEs where the user have scored more than 62% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_62_pe_id");
			entity.Property(e => e.First65McqId)
				.HasComment("saves the task_id of MCQs where the user have scored more than 65 and less than 100% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_65_mcq_id");
			entity.Property(e => e.First85AqId)
				.HasComment("saves the task_id of AQs where the user have scored more than 84 and less than 100% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_85_aq_id");
			entity.Property(e => e.First85AqVideoId)
				.HasComment("saves the video_id of the AQ exam where the user have scored more than 84 and less than 100% for first time")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_85_aq_video_id");
			entity.Property(e => e.FirstVideoSubjectCompleted)
				.HasComment("first completed subject id of the lecture videos")
				.HasColumnType("bigint(20)")
				.HasColumnName("first_video_subject_completed");
			entity.Property(e => e.IdCourse)
				.HasComment("course id")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdReg)
				.HasComment("course enrollment id")
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasComment("User id")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.TaskType)
				.IsRequired()
				.HasComment("task type")
				.HasColumnType("enum('video','subject_outline','multiple','essay','essay_exam','performance_test','short_answer','graded_essay','milestone_exam','review','intermittent_quiz')")
				.HasColumnName("task_type");
			entity.Property(e => e.TotalNumOfTasks)
				.HasComment("total number of tasks available per task type")
				.HasColumnType("int(11)")
				.HasColumnName("total_num_of_tasks");
			entity.Property(e => e.UpdatedAt)
				.HasComment("updated at")
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.LearnersCourseProgressAwards)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_course_cpa_id_course_courses");

			entity.HasOne(d => d.IdRegNavigation).WithMany(p => p.LearnersCourseProgressAwards)
				.HasForeignKey(d => d.IdReg)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_reg_cpa_id_reg_ce");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.LearnersCourseProgressAwards)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_user_cpa_id_user_users");
		});

		modelBuilder.Entity<LearnersLawSchool>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity
				.ToTable("learners_law_schools")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdUser)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.GraduationDate).HasColumnName("graduation_date");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdProgramType)
				.HasColumnType("int(11)")
				.HasColumnName("id_program_type");
			entity.Property(e => e.LawSchoolStartDate).HasColumnName("law_school_start_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.LearnersLawSchool)
				.HasForeignKey<LearnersLawSchool>(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_learners_law_schools_learners");
		});

		modelBuilder.Entity<LearnersMemo>(entity =>
		{
			entity.HasKey(e => e.IdMemo).HasName("PRIMARY");

			entity.ToTable("learners_memos");

			entity.HasIndex(e => e.Active, "active");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.IdFlag, "id_flag");

			entity.HasIndex(e => e.IdReg, "id_reg");

			entity.HasIndex(e => e.IdUser, "learners_memos_id_user");

			entity.Property(e => e.IdMemo)
				.HasColumnType("int(11)")
				.HasColumnName("id_memo");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Author)
				.HasColumnType("int(11)")
				.HasColumnName("author");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdFlag)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_flag");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Memo)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("memo");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<LearnersSelfAssessElement>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdTask, e.IdWrittenQuestion, e.IdElement })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

			entity
				.ToTable("learners_self_assess_elements")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdElement)
				.HasColumnType("int(11)")
				.HasColumnName("id_element");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IsSelected).HasColumnName("is_selected");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<LearnersSelfAssessment>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdTask, e.IdWrittenQuestion })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity
				.ToTable("learners_self_assessments")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.SelfAssessmentCompleted)
				.HasColumnType("datetime")
				.HasColumnName("self_assessment_completed");
			entity.Property(e => e.TaskCompleted)
				.HasColumnType("datetime")
				.HasColumnName("task_completed");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<LogEvent>(entity =>
		{
			entity.HasKey(e => e.IdLogEvent).HasName("PRIMARY");

			entity.ToTable("log_events");

			entity.HasIndex(e => e.Datetime, "datetime");

			entity.HasIndex(e => e.IdAddonTarget, "id_addon_target");

			entity.HasIndex(e => e.IdBillingInvoiceTarget, "id_billing_invoice_target");

			entity.HasIndex(e => e.IdLogEventType, "id_log_event_type");

			entity.HasIndex(e => e.IdRegTarget, "id_reg_target");

			entity.HasIndex(e => e.IdUserSource, "id_user_source");

			entity.HasIndex(e => e.IdUserTarget, "id_user_target");

			entity.HasIndex(e => e.TransType, "trans_type");

			entity.Property(e => e.IdLogEvent)
				.HasColumnType("int(11)")
				.HasColumnName("id_log_event");
			entity.Property(e => e.Amount)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("amount");
			entity.Property(e => e.Balance)
				.HasPrecision(10, 2)
				.HasColumnName("balance");
			entity.Property(e => e.Datetime)
				.HasColumnType("datetime")
				.HasColumnName("datetime");
			entity.Property(e => e.ExtraData)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("extra_data");
			entity.Property(e => e.IdAddonTarget)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_addon_target");
			entity.Property(e => e.IdBillingInvoiceTarget)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_billing_invoice_target");
			entity.Property(e => e.IdLogEventType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_log_event_type");
			entity.Property(e => e.IdRegTarget)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg_target");
			entity.Property(e => e.IdUserSource)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user_source");
			entity.Property(e => e.IdUserTarget)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user_target");
			entity.Property(e => e.Message)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("message");
			entity.Property(e => e.TransType)
				.IsRequired()
				.HasMaxLength(12)
				.HasColumnName("trans_type");
		});

		modelBuilder.Entity<LogEventType>(entity =>
		{
			entity.HasKey(e => e.IdLogEventType).HasName("PRIMARY");

			entity.ToTable("log_event_types");

			entity.HasIndex(e => e.Order, "order");

			entity.HasIndex(e => e.SystemName, "system_name").IsUnique();

			entity.Property(e => e.IdLogEventType)
				.HasColumnType("int(11)")
				.HasColumnName("id_log_event_type");
			entity.Property(e => e.Context)
				.IsRequired()
				.HasMaxLength(12)
				.HasColumnName("context");
			entity.Property(e => e.DisplayName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("display_name");
			entity.Property(e => e.Order)
				.HasColumnType("int(11)")
				.HasColumnName("order");
			entity.Property(e => e.SystemName)
				.IsRequired()
				.HasMaxLength(40)
				.HasColumnName("system_name");
			entity.Property(e => e.TransType)
				.IsRequired()
				.HasMaxLength(8)
				.HasColumnName("trans_type");
		});

		modelBuilder.Entity<McqFeedback>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("mcq_feedback");

			entity.HasIndex(e => e.IdCourse, "fk_mcq_feedback_id_course");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "mcq_feedback_id_multiple_choice_questions");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse, e.IdMultipleChoiceQuestion }, "mcq_feedback_id_user_course_multiple_choice_questions");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Feedback)
				.HasColumnType("text")
				.HasColumnName("feedback");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.McqFeedbacks)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_mcq_feedback_id_course");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.McqFeedbacks)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_mcq_feedback_id_multiple_choice_question");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.McqFeedbacks)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_mcq_feedback_id_user");
		});

		modelBuilder.Entity<McqSession>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("mcq_sessions");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.BeginDatetime)
				.HasColumnType("datetime")
				.HasColumnName("begin_datetime");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.RequestedCount)
				.HasColumnType("int(11)")
				.HasColumnName("requested_count");
		});

		modelBuilder.Entity<McqSetResult>(entity =>
		{
			entity.HasKey(e => new { e.IdMilestoneExam, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("mcq_set_results");

			entity.HasIndex(e => e.IdCourse, "fk_mcq_set_results_courses");

			entity.Property(e => e.IdMilestoneExam)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_milestone_exam");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnsweredCount)
				.HasColumnType("bigint(20)")
				.HasColumnName("answered_count");
			entity.Property(e => e.CorrectCount)
				.HasColumnType("bigint(20)")
				.HasColumnName("correct_count");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.McqSetResults)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_mcq_set_results_courses");

			entity.HasOne(d => d.IdMilestoneExamNavigation).WithMany(p => p.McqSetResults)
				.HasForeignKey(d => d.IdMilestoneExam)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_mcq_set_results_milestone_exams");
		});

		modelBuilder.Entity<Member>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("members")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.EmailNormalized, "index_members_on_email_normalized").IsUnique();

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.EmailNormalized)
				.HasMaxLength(100)
				.HasColumnName("email_normalized");
			entity.Property(e => e.EmailSpecified)
				.HasMaxLength(100)
				.HasColumnName("email_specified");
			entity.Property(e => e.Firstname)
				.HasMaxLength(60)
				.HasColumnName("firstname");
			entity.Property(e => e.FullNameSpecified)
				.HasMaxLength(100)
				.HasColumnName("full_name_specified");
			entity.Property(e => e.GeoCity)
				.HasMaxLength(50)
				.HasColumnName("geo_city");
			entity.Property(e => e.GeoCountry)
				.HasMaxLength(4)
				.HasColumnName("geo_country");
			entity.Property(e => e.GeoState)
				.HasMaxLength(2)
				.HasColumnName("geo_state");
			entity.Property(e => e.GraduationDate).HasColumnName("graduation_date");
			entity.Property(e => e.HasOptedOutOfEmailMarketing).HasColumnName("has_opted_out_of_email_marketing");
			entity.Property(e => e.HasPassedBarExam).HasColumnName("has_passed_bar_exam");
			entity.Property(e => e.HasPassedMpre).HasColumnName("has_passed_mpre");
			entity.Property(e => e.HasTakenBarExam).HasColumnName("has_taken_bar_exam");
			entity.Property(e => e.HasTakenMpre).HasColumnName("has_taken_mpre");
			entity.Property(e => e.HttpReferrer)
				.HasMaxLength(255)
				.HasColumnName("http_referrer");
			entity.Property(e => e.InterestedInBarReview).HasColumnName("interested_in_bar_review");
			entity.Property(e => e.InterestedInBarReviewReminders).HasColumnName("interested_in_bar_review_reminders");
			entity.Property(e => e.InterestedInGeneralInfo).HasColumnName("interested_in_general_info");
			entity.Property(e => e.InterestedInLse).HasColumnName("interested_in_lse");
			entity.Property(e => e.InterestedInLseFirstYear).HasColumnName("interested_in_lse_first_year");
			entity.Property(e => e.InterestedInLseUpperLevel).HasColumnName("interested_in_lse_upper_level");
			entity.Property(e => e.InterestedInMpreReview).HasColumnName("interested_in_mpre_review");
			entity.Property(e => e.InterestedInMpreReviewReminders).HasColumnName("interested_in_mpre_review_reminders");
			entity.Property(e => e.LastBarExamDate).HasColumnName("last_bar_exam_date");
			entity.Property(e => e.LastBarReviewDate).HasColumnName("last_bar_review_date");
			entity.Property(e => e.LastLseFirstYearDate).HasColumnName("last_lse_first_year_date");
			entity.Property(e => e.LastLseUpperLevelDate).HasColumnName("last_lse_upper_level_date");
			entity.Property(e => e.LastMpreDate).HasColumnName("last_mpre_date");
			entity.Property(e => e.LastMpreReviewDate).HasColumnName("last_mpre_review_date");
			entity.Property(e => e.Lastname)
				.HasMaxLength(60)
				.HasColumnName("lastname");
			entity.Property(e => e.LawSchoolId)
				.HasColumnType("int(11)")
				.HasColumnName("law_school_id");
			entity.Property(e => e.LawSchoolName)
				.HasMaxLength(50)
				.HasColumnName("law_school_name");
			entity.Property(e => e.LawSchoolStartDate).HasColumnName("law_school_start_date");
			entity.Property(e => e.NextBarExamDate).HasColumnName("next_bar_exam_date");
			entity.Property(e => e.NextBarExamState)
				.HasMaxLength(2)
				.HasColumnName("next_bar_exam_state");
			entity.Property(e => e.NextMpreDate).HasColumnName("next_mpre_date");
			entity.Property(e => e.PhoneNormalized)
				.HasMaxLength(25)
				.HasColumnName("phone_normalized");
			entity.Property(e => e.PhoneSpecified)
				.HasMaxLength(25)
				.HasColumnName("phone_specified");
			entity.Property(e => e.RemoteIpAddr)
				.HasMaxLength(25)
				.HasColumnName("remote_ip_addr");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UserAgent)
				.HasMaxLength(255)
				.HasColumnName("user_agent");
			entity.Property(e => e.UtmCampaign)
				.HasMaxLength(60)
				.HasColumnName("utm_campaign");
			entity.Property(e => e.UtmContent)
				.HasMaxLength(60)
				.HasColumnName("utm_content");
			entity.Property(e => e.UtmMedium)
				.HasMaxLength(60)
				.HasColumnName("utm_medium");
			entity.Property(e => e.UtmSource)
				.HasMaxLength(60)
				.HasColumnName("utm_source");
			entity.Property(e => e.UtmTerm)
				.HasMaxLength(60)
				.HasColumnName("utm_term");
			entity.Property(e => e.Uvt)
				.HasMaxLength(100)
				.HasColumnName("uvt");
			entity.Property(e => e.XForwardedForIpAddr)
				.HasMaxLength(25)
				.HasColumnName("x_forwarded_for_ip_addr");
		});

		modelBuilder.Entity<MemberActivity>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("member_activities")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.MemberId, e.ActivityType, e.ActivityAt }, "index_member_activities_id_type_specified");

			entity.HasIndex(e => e.ActivityAt, "index_member_activities_on_activity_at");

			entity.HasIndex(e => new { e.MemberId, e.ActivityAt }, "index_member_activities_on_member_id_and_activity_at");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.ActivityAt)
				.HasColumnType("datetime")
				.HasColumnName("activity_at");
			entity.Property(e => e.ActivityType)
				.IsRequired()
				.HasMaxLength(60)
				.HasColumnName("activity_type");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.MemberId)
				.HasColumnType("int(11)")
				.HasColumnName("member_id");
			entity.Property(e => e.Param1)
				.HasMaxLength(60)
				.HasColumnName("param1");
		});

		modelBuilder.Entity<MemberPopulationJobEvent>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("member_population_job_events")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.CreatedAt, "index_member_population_job_events_on_created_at");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.ExistingRecordsStaleBefore)
				.HasColumnType("datetime")
				.HasColumnName("existing_records_stale_before");
			entity.Property(e => e.LeadIdLowerBound)
				.HasColumnType("int(11)")
				.HasColumnName("lead_id_lower_bound");
			entity.Property(e => e.LeadIdUpperBound)
				.HasColumnType("int(11)")
				.HasColumnName("lead_id_upper_bound");
			entity.Property(e => e.NumLeadsAttempted)
				.HasColumnType("int(11)")
				.HasColumnName("num_leads_attempted");
			entity.Property(e => e.NumLeadsProcessed)
				.HasColumnType("int(11)")
				.HasColumnName("num_leads_processed");
			entity.Property(e => e.NumMemberedLeads)
				.HasColumnType("int(11)")
				.HasColumnName("num_membered_leads");
			entity.Property(e => e.NumMemberedUsers)
				.HasColumnType("int(11)")
				.HasColumnName("num_membered_users");
			entity.Property(e => e.NumUnmemberedLeads)
				.HasColumnType("int(11)")
				.HasColumnName("num_unmembered_leads");
			entity.Property(e => e.NumUnmemberedUsers)
				.HasColumnType("int(11)")
				.HasColumnName("num_unmembered_users");
			entity.Property(e => e.NumUsersAttempted)
				.HasColumnType("int(11)")
				.HasColumnName("num_users_attempted");
			entity.Property(e => e.NumUsersProcessed)
				.HasColumnType("int(11)")
				.HasColumnName("num_users_processed");
			entity.Property(e => e.UserIdLowerBound)
				.HasColumnType("int(11)")
				.HasColumnName("user_id_lower_bound");
			entity.Property(e => e.UserIdUpperBound)
				.HasColumnType("int(11)")
				.HasColumnName("user_id_upper_bound");
		});

		modelBuilder.Entity<Message>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("messages")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdUser, "fk_messages_users1");

			entity.HasIndex(e => e.MessageType, "message_type");

			entity.HasIndex(e => e.Active, "messages_active");

			entity.HasIndex(e => e.Date, "messages_date_index");

			entity.Property(e => e.IdMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Date)
				.HasColumnType("datetime")
				.HasColumnName("date");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasComment("the user who sent the message")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.MessageComments)
				.HasColumnType("text")
				.HasColumnName("message_comments");
			entity.Property(e => e.MessageSubject)
				.HasColumnType("text")
				.HasColumnName("message_subject");
			entity.Property(e => e.MessageText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("message_text");
			entity.Property(e => e.MessageType)
				.IsRequired()
				.HasColumnType("enum('learner','adminUser','broadcast','admin','adminPending')")
				.HasColumnName("message_type");
			entity.Property(e => e.Title)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("title");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Messages)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_messages_users1");
		});

		modelBuilder.Entity<MessageAttachment>(entity =>
		{
			entity.HasKey(e => e.IdMessageAttachment).HasName("PRIMARY");

			entity
				.ToTable("message_attachments")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdMessage, "fk_message_attachments_messages1");

			entity.HasIndex(e => e.Active, "message_attachments_active");

			entity.Property(e => e.IdMessageAttachment)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message_attachment");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.AttachmentName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("attachment_name");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithMany(p => p.MessageAttachments)
				.HasForeignKey(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_message_attachments_messages1");
		});

		modelBuilder.Entity<MessageDetail>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity.ToTable("message_details");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_learner_id_outline_section");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.AdminIdQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("admin_id_question");
			entity.Property(e => e.ChangeFlag).HasColumnName("change_flag");
			entity.Property(e => e.IdMessageRelevantContent)
				.HasColumnType("int(11)")
				.HasColumnName("id_message_relevant_content");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.LearnerIdQuestion)
				.HasMaxLength(255)
				.HasColumnName("learner_id_question");
			entity.Property(e => e.LearnerIdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("learner_id_subject_outline");
			entity.Property(e => e.Lecture)
				.HasMaxLength(255)
				.HasColumnName("lecture");
			entity.Property(e => e.NumberOfQuestions).HasColumnName("number_of_questions");
		});

		modelBuilder.Entity<MessageRelevantContent>(entity =>
		{
			entity.HasKey(e => e.IdMessageRelevantContent).HasName("PRIMARY");

			entity.ToTable("message_relevant_contents");

			entity.Property(e => e.IdMessageRelevantContent)
				.ValueGeneratedNever()
				.HasColumnType("int(11)")
				.HasColumnName("id_message_relevant_content");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
		});

		modelBuilder.Entity<MessageStatus>(entity =>
		{
			entity.HasKey(e => new { e.IdMessage, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("message_status", tb => tb.HasComment("both broadcast messages and reply messages need to be marked"))
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdMessage, "fk_message_is_read_messages1");

			entity.HasIndex(e => e.IdUser, "fk_message_is_read_users1");

			entity.HasIndex(e => e.Active, "message_status_active");

			entity.Property(e => e.IdMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ReadStatus)
				.IsRequired()
				.HasColumnType("enum('Read','Unread')")
				.HasColumnName("read_status");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMessageNavigation).WithMany(p => p.MessageStatuses)
				.HasForeignKey(d => d.IdMessage)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_message_is_read_messages1");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.MessageStatuses)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_message_is_read_users1");
		});

		modelBuilder.Entity<MigrationVersion>(entity =>
		{
			entity.HasKey(e => e.Version).HasName("PRIMARY");

			entity
				.ToTable("migration_versions")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.Property(e => e.Version)
				.HasMaxLength(14)
				.HasColumnName("version");
			entity.Property(e => e.ExecutedAt)
				.HasComment("(DC2Type:datetime_immutable)")
				.HasColumnType("datetime")
				.HasColumnName("executed_at");
		});

		modelBuilder.Entity<MilestoneExam>(entity =>
		{
			entity.HasKey(e => e.IdMilestoneExam).HasName("PRIMARY");

			entity
				.ToTable("milestone_exams")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => new { e.Active, e.Enabled, e.IdOutlineClassification }, "enabled_by_classification");

			entity.HasIndex(e => new { e.Enabled, e.Active }, "enabled_ones");

			entity.HasIndex(e => e.IdOutlineClassification, "fk_milestone_exams_outlines_classifications1");

			entity.HasIndex(e => e.Active, "milestone_exams_active");

			entity.Property(e => e.IdMilestoneExam)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_milestone_exam");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(100)
				.HasColumnName("name");
			entity.Property(e => e.QuestionsQuantity)
				.HasColumnType("tinyint(4)")
				.HasColumnName("questions_quantity");
			entity.Property(e => e.TimeLimit).HasColumnName("time_limit");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.MilestoneExams)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_milestone_exams_outlines_classifications1");
		});

		modelBuilder.Entity<MilestoneExamTaskAttempt>(entity =>
		{
			entity.HasKey(e => e.IdMilestoneExamTaskAttempt).HasName("PRIMARY");

			entity.ToTable("milestone_exam_task_attempts");

			entity.Property(e => e.IdMilestoneExamTaskAttempt)
				.HasColumnType("int(11)")
				.HasColumnName("id_milestone_exam_task_attempt");
			entity.Property(e => e.ClosedType)
				.HasColumnType("text")
				.HasColumnName("closed_type");
			entity.Property(e => e.CompletedDatetime)
				.HasColumnType("datetime")
				.HasColumnName("completed_datetime");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ExamReset)
				.HasColumnType("tinyint(4)")
				.HasColumnName("exam_reset");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.ResetIdUser)
				.HasColumnType("int(11)")
				.HasColumnName("reset_id_user");
			entity.Property(e => e.StartedDatetime)
				.HasColumnType("datetime")
				.HasColumnName("started_datetime");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<MilestoneExamsMultipleChoiceQuestion>(entity =>
		{
			entity.HasKey(e => new { e.IdMultipleChoiceQuestion, e.IdMilestoneExam })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("milestone_exams_multiple_choice_questions")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => new { e.IdMilestoneExam, e.Active }, "active_by_exam");

			entity.HasIndex(e => e.IdMilestoneExam, "fk_id_milestone_exam");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "fk_id_multiple_choice_question");

			entity.HasIndex(e => e.Active, "milestone_exams_multiple_choice_questions_active");

			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdMilestoneExam)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_milestone_exam");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMilestoneExamNavigation).WithMany(p => p.MilestoneExamsMultipleChoiceQuestions)
				.HasForeignKey(d => d.IdMilestoneExam)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_milestone_exam");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.MilestoneExamsMultipleChoiceQuestions)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_multiple_choice_question");
		});

		modelBuilder.Entity<MilestoneQuestionsTasksLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdMultipleChoiceQuestion, e.IdTask })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity
				.ToTable("milestone_questions_tasks_learners")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdUser, "fk_milestone_questions_tasks_learners_learners1");

			entity.HasIndex(e => e.IdAnswer, "id_answer");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "id_multiple_choice_question");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "milestone_questions_tasks_learners_active");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.ReviewLater)
				.HasColumnType("tinyint(4)")
				.HasColumnName("review_later");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.MilestoneQuestionsTasksLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_milestone_questions_tasks_learners_learners10");
		});

		modelBuilder.Entity<MultipleChoiceQuestion>(entity =>
		{
			entity.HasKey(e => e.IdMultipleChoiceQuestion).HasName("PRIMARY");

			entity.ToTable("multiple_choice_questions");

			entity.HasIndex(e => e.IdQuestionBatch, "id_question_batch_index");

			entity.HasIndex(e => e.Active, "multiple_choice_questions_active");

			entity.HasIndex(e => e.IdQuestion, "multiple_choice_questions_fk_id_question");

			entity.HasIndex(e => e.IdQuestionType, "question_type");

			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question");
			entity.Property(e => e.IdQuestionBatch)
				.HasColumnType("bigint(11)")
				.HasColumnName("id_question_batch");
			entity.Property(e => e.IdQuestionType)
				.HasColumnType("int(4)")
				.HasColumnName("id_question_type");
			entity.Property(e => e.Identifier)
				.HasMaxLength(10)
				.HasColumnName("identifier");
			entity.Property(e => e.Notes)
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.QuestionRationale)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_rationale");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.UworldQuestionId)
				.HasColumnType("int(4)")
				.HasColumnName("uworld_question_id");

			entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.MultipleChoiceQuestions)
				.HasForeignKey(d => d.IdQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("multiple_choice_questions_fk_id_question");
		});

		modelBuilder.Entity<MultipleChoiceQuestionsLearner>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("multiple_choice_questions_learners");

			entity.HasIndex(e => e.IdUser, "id_course_id_user_index");

			entity.HasIndex(e => new { e.IdUser, e.IdTask }, "id_user_id_task_index");

			entity.HasIndex(e => new { e.IdCourse, e.IdUser }, "mcql_course_user");

			entity.HasIndex(e => new { e.IdMultipleChoiceQuestion, e.IdAnswer }, "mcql_mcq_answer");

			entity.HasIndex(e => e.IdMcqSession, "mcql_session");

			entity.Property(e => e.Id)
				.HasColumnType("bigint(20)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAnswer)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_answer");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdMcqSession)
				.HasColumnType("int(11)")
				.HasColumnName("id_mcq_session");
			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<MultipleChoiceSet>(entity =>
		{
			entity.HasKey(e => e.IdMultipleChoiceSet).HasName("PRIMARY");

			entity.ToTable("multiple_choice_sets");

			entity.HasIndex(e => e.IdOutlineClassification, "fk_multiple_choice_sets_outlines_classifiactions");

			entity.Property(e => e.IdMultipleChoiceSet)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_set");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.QuestionsQuantity)
				.HasColumnType("tinyint(4) unsigned")
				.HasColumnName("questions_quantity");
			entity.Property(e => e.SetType)
				.IsRequired()
				.HasMaxLength(8)
				.HasDefaultValueSql("'course'")
				.HasColumnName("set_type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.MultipleChoiceSets)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_multiple_choice_sets_outlines_classifiactions");
		});

		modelBuilder.Entity<MultipleChoiceSetsMultipleChoiceQuestion>(entity =>
		{
			entity.HasKey(e => new { e.IdMultipleChoiceQuestion, e.IdMultipleChoiceSet })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("multiple_choice_sets_multiple_choice_questions");

			entity.HasIndex(e => e.IdMultipleChoiceQuestion, "fk_id_multiple_choice_question");

			entity.HasIndex(e => e.IdMultipleChoiceSet, "fk_id_multiple_choice_set");

			entity.Property(e => e.IdMultipleChoiceQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_question");
			entity.Property(e => e.IdMultipleChoiceSet)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_set");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4) unsigned")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMultipleChoiceQuestionNavigation).WithMany(p => p.MultipleChoiceSetsMultipleChoiceQuestions)
				.HasForeignKey(d => d.IdMultipleChoiceQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_multiple_choice_question_set");

			entity.HasOne(d => d.IdMultipleChoiceSetNavigation).WithMany(p => p.MultipleChoiceSetsMultipleChoiceQuestions)
				.HasForeignKey(d => d.IdMultipleChoiceSet)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_multiple_choice_set_question");
		});

		modelBuilder.Entity<MultipleChoiceSubjectsUsersAverage>(entity =>
		{
			entity.HasKey(e => new { e.QuestionAverageType, e.IdQuestionAverage })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("multiple_choice_subjects_users_average")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.QuestionAverageType)
				.HasDefaultValueSql("'multiple'")
				.HasColumnType("enum('multiple','milestone_exam')")
				.HasColumnName("question_average_type");
			entity.Property(e => e.IdQuestionAverage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question_average");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Correct)
				.HasColumnType("bigint(20)")
				.HasColumnName("correct");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Total)
				.HasColumnType("bigint(20)")
				.HasColumnName("total");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<MyLog>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("my_log");

			entity.Property(e => e.Comment)
				.HasMaxLength(255)
				.HasColumnName("comment");
			entity.Property(e => e.T)
				.HasColumnType("datetime")
				.HasColumnName("t");
		});

		modelBuilder.Entity<OutlinesClassification>(entity =>
		{
			entity.HasKey(e => e.IdOutlineClassification).HasName("PRIMARY");

			entity.ToTable("outlines_classifications");

			entity.HasIndex(e => e.Active, "outlines_classifications_active");

			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("description");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<OutlinesClassificationsEmail>(entity =>
		{
			entity.HasKey(e => e.IdOutlineClassification).HasName("PRIMARY");

			entity
				.ToTable("outlines_classifications_emails")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdOutlineClassification)
				.HasMaxLength(25)
				.HasDefaultValueSql("''")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.AdviserQuestionOverrideEmail)
				.HasMaxLength(100)
				.HasColumnName("adviser_question_override_email");
			entity.Property(e => e.Email)
				.HasMaxLength(255)
				.HasColumnName("email");
			entity.Property(e => e.GradedEssayOverrideEmail)
				.HasMaxLength(100)
				.HasColumnName("graded_essay_override_email");
			entity.Property(e => e.StudyStrategiesOverrideEmail)
				.HasMaxLength(100)
				.HasColumnName("study_strategies_override_email");
		});

		modelBuilder.Entity<PassRate>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("pass_rates")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.OurSummer2011PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_summer_2011_pass_rates");
			entity.Property(e => e.OurSummer2012PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_summer_2012_pass_rates");
			entity.Property(e => e.OurSummer2013PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_summer_2013_pass_rates");
			entity.Property(e => e.OurSummer201475PercentCompletionPassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_summer_2014_75_percent_completion_pass_rates");
			entity.Property(e => e.OurSummer2014PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_summer_2014_pass_rates");
			entity.Property(e => e.OurWinter2013PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_winter_2013_pass_rates");
			entity.Property(e => e.OurWinter2014PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("our_winter_2014_pass_rates");
			entity.Property(e => e.PublicSummer2011PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_summer_2011_pass_rates");
			entity.Property(e => e.PublicSummer2012PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_summer_2012_pass_rates");
			entity.Property(e => e.PublicSummer2013PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_summer_2013_pass_rates");
			entity.Property(e => e.PublicSummer2014PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_summer_2014_pass_rates");
			entity.Property(e => e.PublicWinter2013PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_winter_2013_pass_rates");
			entity.Property(e => e.PublicWinter2014PassRates)
				.HasColumnType("int(11)")
				.HasColumnName("public_winter_2014_pass_rates");
			entity.Property(e => e.UsStateId)
				.HasColumnType("int(11)")
				.HasColumnName("us_state_id");
		});

		modelBuilder.Entity<PassRateInquiry>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("pass_rate_inquiries");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email");
			entity.Property(e => e.EmailedTo)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("emailed_to");
			entity.Property(e => e.FirstName)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("first_name");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Message)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("message");
		});

		modelBuilder.Entity<PaymentInfo>(entity =>
		{
			entity.HasKey(e => e.IdPaymentInfo).HasName("PRIMARY");

			entity.ToTable("payment_info");

			entity.HasIndex(e => e.IdCcTransaction, "id_cc_transaction");

			entity.HasIndex(e => e.Processor, "processor");

			entity.HasIndex(e => e.Type, "type");

			entity.Property(e => e.IdPaymentInfo)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_info");
			entity.Property(e => e.BillingPayment).HasColumnName("billing_payment");
			entity.Property(e => e.CardType)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("card_type");
			entity.Property(e => e.CcNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("cc_number");
			entity.Property(e => e.CheckNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("check_number");
			entity.Property(e => e.IdAffirmTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_affirm_transaction");
			entity.Property(e => e.IdCcTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_cc_transaction");
			entity.Property(e => e.Initials)
				.IsRequired()
				.HasMaxLength(2)
				.HasColumnName("initials");
			entity.Property(e => e.NameOnCheck)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name_on_check");
			entity.Property(e => e.Processor)
				.IsRequired()
				.HasMaxLength(12)
				.HasColumnName("processor");
			entity.Property(e => e.ReferenceNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("reference_number");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(10)
				.HasDefaultValueSql("''")
				.HasColumnName("type");
		});

		modelBuilder.Entity<PaymentPlan>(entity =>
		{
			entity.HasKey(e => e.IdPaymentPlan).HasName("PRIMARY");

			entity.ToTable("payment_plan");

			entity.HasIndex(e => new { e.DateDue, e.Paid }, "date_paid");

			entity.HasIndex(e => new { e.IdReg, e.IdAddon, e.IdUser }, "search").IsUnique();

			entity.Property(e => e.IdPaymentPlan)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_plan");
			entity.Property(e => e.AmountDue)
				.HasPrecision(10, 2)
				.HasColumnName("amount_due");
			entity.Property(e => e.DateDue)
				.HasColumnType("datetime")
				.HasColumnName("date_due");
			entity.Property(e => e.IdAddon)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_addon");
			entity.Property(e => e.IdAuthorizedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_authorized_by");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Paid).HasColumnName("paid");
		});

		modelBuilder.Entity<PermissionsAreasRole>(entity =>
		{
			entity.HasKey(e => new { e.IdArea, e.IdAction, e.IdRole })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("permissions_areas_roles", tb => tb.HasComment("Login type level permissions"));

			entity.HasIndex(e => new { e.IdArea, e.IdAction, e.IdRole, e.Granted, e.Created, e.Updated }, "permissions_areas_roles_all_index");

			entity.Property(e => e.IdArea)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_area");
			entity.Property(e => e.IdAction)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_action");
			entity.Property(e => e.IdRole)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_role");
			entity.Property(e => e.Created)
				.HasComment("Date time created")
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Granted)
				.HasComment("Permission is granted or not")
				.HasColumnName("granted");
			entity.Property(e => e.Updated)
				.HasComment("Date time last updated")
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<PermissionsAreasUser>(entity =>
		{
			entity.HasKey(e => new { e.IdArea, e.IdUser, e.IdAction })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("permissions_areas_users", tb => tb.HasComment("User level permissions"));

			entity.Property(e => e.IdArea)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_area");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdAction)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_action");
			entity.Property(e => e.Created)
				.HasComment("Date time created")
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Granted)
				.HasComment("Permission is granted or not")
				.HasColumnName("granted");
			entity.Property(e => e.Updated)
				.HasComment("Date time last updated")
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<PersistentSetting>(entity =>
		{
			entity.HasKey(e => e.SettingKey).HasName("PRIMARY");

			entity.ToTable("persistent_settings");

			entity.HasIndex(e => e.SettingValue, "persistent_settings_setting_value_index");

			entity.Property(e => e.SettingKey).HasColumnName("setting_key");
			entity.Property(e => e.SettingValue)
				.IsRequired()
				.HasColumnName("setting_value");
		});

		modelBuilder.Entity<ProgramType>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("program_types");

			entity.Property(e => e.Abbreviation)
				.HasMaxLength(8)
				.HasColumnName("abbreviation");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(64)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Promo>(entity =>
		{
			entity.HasKey(e => e.IdPromo).HasName("PRIMARY");

			entity
				.ToTable("promos")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.Code)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("code");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("description");
			entity.Property(e => e.EndDate).HasColumnName("end_date");
			entity.Property(e => e.IdPromoConditional)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_conditional");
			entity.Property(e => e.IdPromoType)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_type");
			entity.Property(e => e.IsPercentage).HasColumnName("is_percentage");
			entity.Property(e => e.StartDate).HasColumnName("start_date");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasColumnType("enum('standard','discount','add-on')")
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<PromoCondition>(entity =>
		{
			entity.HasKey(e => e.IdPromoCondition).HasName("PRIMARY");

			entity.ToTable("promo_conditions");

			entity.HasIndex(e => e.IdPromoConditional, "id_promo_conditional");

			entity.Property(e => e.IdPromoCondition)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_condition");
			entity.Property(e => e.Action).HasColumnName("action");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.Balance)
				.HasPrecision(10, 2)
				.HasColumnName("balance");
			entity.Property(e => e.Deadline)
				.HasColumnType("datetime")
				.HasColumnName("deadline");
			entity.Property(e => e.IdAddonType)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon_type");
			entity.Property(e => e.IdPromoConditional)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_conditional");
			entity.Property(e => e.InvoiceNote)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("invoice_note");
			entity.Property(e => e.PaymentRequirement).HasColumnName("payment_requirement");
		});

		modelBuilder.Entity<PromoConditional>(entity =>
		{
			entity.HasKey(e => e.IdPromoConditional).HasName("PRIMARY");

			entity.ToTable("promo_conditional");

			entity.HasIndex(e => new { e.IdPromoConditional, e.IdPromoType }, "id_promo_conditional");

			entity.Property(e => e.IdPromoConditional)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_conditional");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Advertisement)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("advertisement");
			entity.Property(e => e.AdvertisementEnd)
				.HasColumnType("datetime")
				.HasColumnName("advertisement_end");
			entity.Property(e => e.AdvertisementStart)
				.HasColumnType("datetime")
				.HasColumnName("advertisement_start");
			entity.Property(e => e.Amount).HasColumnName("amount");
			entity.Property(e => e.ApplyNext).HasColumnName("apply_next");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.IdPromoType)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_type");
			entity.Property(e => e.IdSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_school");
			entity.Property(e => e.IdSeason)
				.HasColumnType("int(11)")
				.HasColumnName("id_season");
			entity.Property(e => e.IdState)
				.HasColumnType("int(11)")
				.HasColumnName("id_state");
			entity.Property(e => e.Title)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("title");
			entity.Property(e => e.Year)
				.HasColumnType("year(4)")
				.HasColumnName("year");
		});

		modelBuilder.Entity<PromoType>(entity =>
		{
			entity.HasKey(e => e.IdPromoType).HasName("PRIMARY");

			entity.ToTable("promo_types");

			entity.HasIndex(e => e.Active, "index_promo_types_on_active");

			entity.HasIndex(e => e.Conditional, "index_promo_types_on_conditional");

			entity.Property(e => e.IdPromoType)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_type");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.AsPercentage).HasColumnName("as_percentage");
			entity.Property(e => e.Conditional)
				.HasColumnType("tinyint(4)")
				.HasColumnName("conditional");
			entity.Property(e => e.MaxPromoAllowace)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo_allowace");
			entity.Property(e => e.PromoCategory)
				.HasMaxLength(255)
				.HasColumnName("promo_category");
			entity.Property(e => e.PromoSubcategory)
				.HasMaxLength(255)
				.HasColumnName("promo_subcategory");
			entity.Property(e => e.SuggestedAmount)
				.HasPrecision(10, 2)
				.HasColumnName("suggested_amount");
			entity.Property(e => e.Toward)
				.IsRequired()
				.HasMaxLength(6)
				.HasColumnName("toward");
		});

		modelBuilder.Entity<PromosCourse>(entity =>
		{
			entity.HasKey(e => new { e.IdPromo, e.IdCourse })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("promos_courses")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCourse, "fk_promos_courses_id_course");

			entity.HasIndex(e => e.IdPromo, "fk_promos_courses_id_promo");

			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.PromosCourses)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_courses_id_course");

			entity.HasOne(d => d.IdPromoNavigation).WithMany(p => p.PromosCourses)
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_courses_id_promo");
		});

		modelBuilder.Entity<PromosCourseType>(entity =>
		{
			entity.HasKey(e => new { e.IdPromo, e.IdCourseType })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("promos_course_types")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCourseType, "fk_promos_course_types_id_course_type");

			entity.HasIndex(e => e.IdPromo, "fk_promos_course_types_id_promo");

			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseTypeNavigation).WithMany(p => p.PromosCourseTypes)
				.HasForeignKey(d => d.IdCourseType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_course_types_id_course_type");

			entity.HasOne(d => d.IdPromoNavigation).WithMany(p => p.PromosCourseTypes)
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_course_types_id_promo");
		});

		modelBuilder.Entity<PromosLawSchool>(entity =>
		{
			entity.HasKey(e => new { e.IdPromo, e.IdLawSchool })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("promos_law_schools")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdLawSchool, "fk_promos_law_schools_id_law_school");

			entity.HasIndex(e => e.IdPromo, "fk_promos_law_schools_id_promo");

			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdLawSchoolNavigation).WithMany(p => p.PromosLawSchools)
				.HasForeignKey(d => d.IdLawSchool)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_law_schools_id_law_school");

			entity.HasOne(d => d.IdPromoNavigation).WithMany(p => p.PromosLawSchools)
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_law_schools_id_promo");
		});

		modelBuilder.Entity<PromosOutlinesClassification>(entity =>
		{
			entity.HasKey(e => new { e.IdPromo, e.IdOutlineClassification })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("promos_outlines_classifications")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdOutlineClassification, "fk_promos_outlines_classifications_id_outline_classification");

			entity.HasIndex(e => e.IdPromo, "fk_promos_outlines_classifications_id_promo");

			entity.Property(e => e.IdPromo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_promo");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.PromosOutlinesClassifications)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_outlines_classifications_id_outline_classification");

			entity.HasOne(d => d.IdPromoNavigation).WithMany(p => p.PromosOutlinesClassifications)
				.HasForeignKey(d => d.IdPromo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_promos_outlines_classifications_id_promo");
		});

		modelBuilder.Entity<ProxyLogin>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("proxy_login")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Md5Key, "md5_key").IsUnique();

			entity.Property(e => e.Datetime)
				.HasColumnType("datetime")
				.HasColumnName("datetime");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Md5Key)
				.IsRequired()
				.HasMaxLength(32)
				.HasColumnName("md5_key");
		});

		modelBuilder.Entity<Question>(entity =>
		{
			entity.HasKey(e => e.IdQuestion).HasName("PRIMARY");

			entity.ToTable("questions");

			entity.HasIndex(e => e.IdSection, "fk_id_section");

			entity.HasIndex(e => e.Active, "questions_active");

			entity.Property(e => e.IdQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdSection)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_section");
			entity.Property(e => e.Media)
				.HasColumnType("text")
				.HasColumnName("media");
			entity.Property(e => e.QuestionStem)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_stem");
			entity.Property(e => e.QuestionTitle)
				.HasColumnType("text")
				.HasColumnName("question_title");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSectionNavigation).WithMany(p => p.Questions)
				.HasForeignKey(d => d.IdSection)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_section");
		});

		modelBuilder.Entity<QuestionBatch>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("question_batches");

			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdQuestionBatch)
				.HasColumnType("int(11)")
				.HasColumnName("id_question_batch");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<QuestionDetail>(entity =>
		{
			entity.HasKey(e => e.IdQuestion).HasName("PRIMARY");

			entity.ToTable("question_details");

			entity.HasIndex(e => e.CognitiveSkill, "index_cognitive_skill");

			entity.Property(e => e.IdQuestion)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_question");
			entity.Property(e => e.CognitiveSkill)
				.HasMaxLength(32)
				.HasColumnName("cognitive_skill");

			entity.HasOne(d => d.IdQuestionNavigation).WithOne(p => p.QuestionDetail)
				.HasForeignKey<QuestionDetail>(d => d.IdQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_questions");
		});

		modelBuilder.Entity<QuestionKeyword>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("question_keywords");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.KeywordText)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("keyword_text");
		});

		modelBuilder.Entity<ReferralType>(entity =>
		{
			entity.HasKey(e => e.IdReferralType).HasName("PRIMARY");

			entity
				.ToTable("referral_types")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Seq, "seq");

			entity.Property(e => e.IdReferralType)
				.ValueGeneratedNever()
				.HasColumnType("int(11)")
				.HasColumnName("id_referral_type");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("name");
			entity.Property(e => e.Seq)
				.HasColumnType("int(11)")
				.HasColumnName("seq");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<RefundInfo>(entity =>
		{
			entity.HasKey(e => e.IdRefundInfo).HasName("PRIMARY");

			entity.ToTable("refund_info");

			entity.Property(e => e.IdRefundInfo)
				.HasColumnType("int(11)")
				.HasColumnName("id_refund_info");
			entity.Property(e => e.BillingPayment).HasColumnName("billing_payment");
			entity.Property(e => e.CardType)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("card_type");
			entity.Property(e => e.CcNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("cc_number");
			entity.Property(e => e.CheckNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("check_number");
			entity.Property(e => e.IdCcTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_cc_transaction");
			entity.Property(e => e.Initials)
				.IsRequired()
				.HasMaxLength(2)
				.HasColumnName("initials");
			entity.Property(e => e.NameOnCheck)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name_on_check");
			entity.Property(e => e.Processor)
				.IsRequired()
				.HasMaxLength(12)
				.HasColumnName("processor");
			entity.Property(e => e.ReferenceNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("reference_number");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(11)
				.HasDefaultValueSql("''")
				.HasColumnName("type");
		});

		modelBuilder.Entity<RegistrationType>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("registration_types");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("ID");
			entity.Property(e => e.OnReport).HasColumnName("on_report");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("type");
		});

		modelBuilder.Entity<ReplyMessage>(entity =>
		{
			entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

			entity
				.ToTable("reply_message")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdMessage, "admin_user_messages_id_message");

			entity.HasIndex(e => e.IdRepliedMessage, "replied_message_id");

			entity.HasIndex(e => e.Active, "reply_message_active");

			entity.Property(e => e.IdMessage)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_message");
			entity.Property(e => e.Active)
				.HasColumnType("tinyint(4)")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdRepliedMessage)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_replied_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<ResetPassword>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("reset_passwords");

			entity.HasIndex(e => e.Md5Key, "md5_key").IsUnique();

			entity.Property(e => e.Datetime)
				.HasColumnType("datetime")
				.HasColumnName("datetime");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Md5Key)
				.IsRequired()
				.HasMaxLength(32)
				.HasColumnName("md5_key");
		});

		modelBuilder.Entity<ReviewNotification>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("review_notifications");

			entity.HasIndex(e => e.CreatedBy, "fk_review_notifications_created_by");

			entity.HasIndex(e => new { e.QuestionType, e.IdQuestion }, "review_notifications_question_type_id_question");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Comments)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("comments");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.CreatedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("created_by");
			entity.Property(e => e.IdQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_question");
			entity.Property(e => e.QuestionType)
				.HasColumnType("enum('mcq','wq','aq')")
				.HasColumnName("question_type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ReviewNotifications)
				.HasForeignKey(d => d.CreatedBy)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_review_notifications_created_by");
		});

		modelBuilder.Entity<ReviewResolution>(entity =>
		{
			entity.HasKey(e => e.IdReviewNotification).HasName("PRIMARY");

			entity.ToTable("review_resolutions");

			entity.HasIndex(e => e.ResolvedBy, "fk_review_resolutions_resolved_by");

			entity.Property(e => e.IdReviewNotification)
				.ValueGeneratedNever()
				.HasColumnType("int(11)")
				.HasColumnName("id_review_notification");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Comments)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("comments");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ResolvedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("resolved_by");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.ResolvedByNavigation).WithMany(p => p.ReviewResolutions)
				.HasForeignKey(d => d.ResolvedBy)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_review_resolutions_resolved_by");
		});

		modelBuilder.Entity<Role>(entity =>
		{
			entity.HasKey(e => e.IdRole).HasName("PRIMARY");

			entity.ToTable("roles");

			entity.HasIndex(e => e.RoleName, "role_name").IsUnique();

			entity.Property(e => e.IdRole)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_role");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.RoleName)
				.IsRequired()
				.HasMaxLength(25)
				.HasColumnName("role_name");
			entity.Property(e => e.Status)
				.IsRequired()
				.HasColumnType("enum('active','inactive')")
				.HasColumnName("status");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<SalesforceQueue>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("salesforce_queues")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Comments)
				.HasMaxLength(255)
				.HasColumnName("comments");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ItemId)
				.HasMaxLength(255)
				.HasColumnName("item_id");
			entity.Property(e => e.SentOn)
				.HasColumnType("datetime")
				.HasColumnName("sent_on");
			entity.Property(e => e.Status)
				.HasMaxLength(255)
				.HasColumnName("status");
			entity.Property(e => e.Type)
				.HasMaxLength(255)
				.HasColumnName("type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<SalesforceSendLog>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("salesforce_send_logs");

			entity.HasIndex(e => new { e.IdUser, e.Created }, "id_user_created_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Data)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("data");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Message)
				.HasColumnType("text")
				.HasColumnName("message");
			entity.Property(e => e.Status)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("status");
		});

		modelBuilder.Entity<SalesforceVariable>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("salesforce_variables")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("id");
			entity.Property(e => e.FieldId)
				.HasMaxLength(255)
				.HasColumnName("field_id");
			entity.Property(e => e.Type)
				.HasMaxLength(255)
				.HasColumnName("type");
			entity.Property(e => e.Value)
				.HasMaxLength(255)
				.HasColumnName("value");
		});

		modelBuilder.Entity<SchemaMigration>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("schema_migrations")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.Version, "unique_schema_migrations").IsUnique();

			entity.Property(e => e.Version)
				.IsRequired()
				.HasColumnName("version");
		});

		modelBuilder.Entity<Season>(entity =>
		{
			entity.HasKey(e => e.IdSeason).HasName("PRIMARY");

			entity.ToTable("seasons");

			entity.Property(e => e.IdSeason)
				.HasColumnType("int(11)")
				.HasColumnName("id_season");
			entity.Property(e => e.Season1)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("season");
			entity.Property(e => e.SeasonAbv)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("season_abv");
		});

		modelBuilder.Entity<Section>(entity =>
		{
			entity.HasKey(e => e.IdSection).HasName("PRIMARY");

			entity.ToTable("sections");

			entity.HasIndex(e => e.IdChapter, "fk_sections_chapters1");

			entity.HasIndex(e => e.Active, "sections_active");

			entity.Property(e => e.IdSection)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_section");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.TextContent)
				.IsRequired()
				.HasColumnType("mediumtext")
				.HasColumnName("text_content");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdChapterNavigation).WithMany(p => p.Sections)
				.HasForeignKey(d => d.IdChapter)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_sections_chapters1");
		});

		modelBuilder.Entity<SelfAssessmentElement>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("self_assessment_elements")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AssessmentType)
				.IsRequired()
				.HasMaxLength(45)
				.HasColumnName("assessment_type");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdSelfAssessmentPart)
				.HasColumnType("int(11)")
				.HasColumnName("id_self_assessment_part");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.Question)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<SelfAssessmentPart>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("self_assessment_parts")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("int(11)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<SesBounce>(entity =>
		{
			entity.HasKey(e => e.IdSesNotification).HasName("PRIMARY");

			entity.ToTable("ses_bounces");

			entity.HasIndex(e => e.IdSesNotification, "fk_id_ses_mail");

			entity.Property(e => e.IdSesNotification)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_notification");
			entity.Property(e => e.BounceSubType)
				.IsRequired()
				.HasMaxLength(32)
				.HasColumnName("bounce_sub_type");
			entity.Property(e => e.BounceType)
				.IsRequired()
				.HasMaxLength(30)
				.HasColumnName("bounce_type");
			entity.Property(e => e.FeedbackId)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("feedback_id");
			entity.Property(e => e.ReportingMta)
				.HasMaxLength(254)
				.HasColumnName("reporting_mta");
			entity.Property(e => e.Timestamp)
				.HasColumnType("datetime")
				.HasColumnName("timestamp");

			entity.HasOne(d => d.IdSesNotificationNavigation).WithOne(p => p.SesBounce)
				.HasForeignKey<SesBounce>(d => d.IdSesNotification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ses_bounces_id_ses_notification");
		});

		modelBuilder.Entity<SesBouncedRecipient>(entity =>
		{
			entity.HasKey(e => e.IdSesBouncedRecipient).HasName("PRIMARY");

			entity.ToTable("ses_bounced_recipients");

			entity.HasIndex(e => e.IdSesNotification, "fk_ses_bounced_recipients_id_ses_notification");

			entity.Property(e => e.IdSesBouncedRecipient)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_bounced_recipient");
			entity.Property(e => e.Action)
				.HasMaxLength(30)
				.IsFixedLength()
				.HasColumnName("action");
			entity.Property(e => e.DiagnosticCode)
				.HasColumnType("text")
				.HasColumnName("diagnostic_code");
			entity.Property(e => e.EmailAddress)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email_address");
			entity.Property(e => e.IdSesNotification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_notification");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Status)
				.HasMaxLength(30)
				.IsFixedLength()
				.HasColumnName("status");

			entity.HasOne(d => d.IdSesNotificationNavigation).WithMany(p => p.SesBouncedRecipients)
				.HasForeignKey(d => d.IdSesNotification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ses_bounced_recipients_id_ses_notification");
		});

		modelBuilder.Entity<SesComplainedRecipient>(entity =>
		{
			entity.HasKey(e => e.IdSesComplainedRecipient).HasName("PRIMARY");

			entity.ToTable("ses_complained_recipients");

			entity.HasIndex(e => e.IdSesNotification, "fk_ses_complained_recipients_id_ses_notification");

			entity.Property(e => e.IdSesComplainedRecipient)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_complained_recipient");
			entity.Property(e => e.EmailAddress)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email_address");
			entity.Property(e => e.IdSesNotification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_notification");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");

			entity.HasOne(d => d.IdSesNotificationNavigation).WithMany(p => p.SesComplainedRecipients)
				.HasForeignKey(d => d.IdSesNotification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ses_complained_recipients_id_ses_notification");
		});

		modelBuilder.Entity<SesComplaint>(entity =>
		{
			entity.HasKey(e => e.IdSesNotification).HasName("PRIMARY");

			entity.ToTable("ses_complaints");

			entity.HasIndex(e => e.IdSesNotification, "fk_id_ses_mail");

			entity.Property(e => e.IdSesNotification)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_notification");
			entity.Property(e => e.ArrivalDate)
				.HasColumnType("datetime")
				.HasColumnName("arrival_date");
			entity.Property(e => e.ComplaintFeedbackType)
				.HasMaxLength(254)
				.HasColumnName("complaint_feedback_type");
			entity.Property(e => e.FeedbackId)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("feedback_id");
			entity.Property(e => e.Timestamp)
				.HasColumnType("datetime")
				.HasColumnName("timestamp");
			entity.Property(e => e.UserAgent)
				.HasMaxLength(254)
				.HasColumnName("user_agent");

			entity.HasOne(d => d.IdSesNotificationNavigation).WithOne(p => p.SesComplaint)
				.HasForeignKey<SesComplaint>(d => d.IdSesNotification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ses_complaints_id_ses_notification");
		});

		modelBuilder.Entity<SesMail>(entity =>
		{
			entity.HasKey(e => e.IdSesMail).HasName("PRIMARY");

			entity.ToTable("ses_mail");

			entity.Property(e => e.IdSesMail)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_mail");
			entity.Property(e => e.Destination)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("destination");
			entity.Property(e => e.MessageId)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("message_id");
			entity.Property(e => e.SendingAccountId)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("sending_account_id");
			entity.Property(e => e.Source)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("source");
			entity.Property(e => e.SourceArn)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("source_arn");
			entity.Property(e => e.Timestamp)
				.HasColumnType("datetime")
				.HasColumnName("timestamp");
		});

		modelBuilder.Entity<SesNotification>(entity =>
		{
			entity.HasKey(e => e.IdSesNotification).HasName("PRIMARY");

			entity.ToTable("ses_notifications");

			entity.HasIndex(e => e.IdSesMail, "fk_ses_notification_id_ses_mail");

			entity.Property(e => e.IdSesNotification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_notification");
			entity.Property(e => e.IdSesMail)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_ses_mail");
			entity.Property(e => e.NotificationType)
				.IsRequired()
				.HasColumnType("enum('Bounce','Complaint')")
				.HasColumnName("notification_type");

			entity.HasOne(d => d.IdSesMailNavigation).WithMany(p => p.SesNotifications)
				.HasForeignKey(d => d.IdSesMail)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_ses_notification_id_ses_mail");
		});

		modelBuilder.Entity<Setting>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("settings", tb => tb.HasComment("holds all the settings to be controlled on the application"));

			entity.HasIndex(e => e.SettingKey, "settings_setting_key_unique_index").IsUnique();

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.Description)
				.HasMaxLength(255)
				.HasColumnName("description");
			entity.Property(e => e.SettingKey)
				.IsRequired()
				.HasColumnName("setting_key");
			entity.Property(e => e.SettingValue)
				.HasMaxLength(255)
				.HasColumnName("setting_value");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");
			entity.Property(e => e.UpdatedBy)
				.HasColumnType("int(11)")
				.HasColumnName("updated_by");
		});

		modelBuilder.Entity<ShippingAdmin>(entity =>
		{
			entity.HasKey(e => e.IdShippingAdmin).HasName("PRIMARY");

			entity.ToTable("shipping_admin");

			entity.Property(e => e.IdShippingAdmin)
				.HasColumnType("int(11)")
				.HasColumnName("id_shipping_admin");
			entity.Property(e => e.CurrencyValue)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("currency_value");
			entity.Property(e => e.CustomerNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("customer_number");
			entity.Property(e => e.FreightAccountNumber)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("freight_account_number");
		});

		modelBuilder.Entity<ShippingBatch>(entity =>
		{
			entity.HasKey(e => e.IdBatch).HasName("PRIMARY");

			entity
				.ToTable("shipping_batch")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdBatch)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_batch");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
		});

		modelBuilder.Entity<ShippingBatchItem>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("shipping_batch_items")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdBatch, "shipping_batch_items_batch_id");

			entity.Property(e => e.Address1)
				.HasMaxLength(255)
				.HasColumnName("address1");
			entity.Property(e => e.Address2)
				.HasMaxLength(255)
				.HasColumnName("address2");
			entity.Property(e => e.City)
				.HasMaxLength(50)
				.HasColumnName("city");
			entity.Property(e => e.IdAddonType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_addon_type");
			entity.Property(e => e.IdBatch)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_batch");
			entity.Property(e => e.IdCountry)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_country");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(5)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdShippingBatchItem)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_shipping_batch_item");
			entity.Property(e => e.IdState)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_state");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Phone)
				.IsRequired()
				.HasMaxLength(30)
				.HasColumnName("phone");
			entity.Property(e => e.ZipCode)
				.HasMaxLength(50)
				.HasColumnName("zip_code");
		});

		modelBuilder.Entity<ShippingMethod>(entity =>
		{
			entity.HasKey(e => e.IdShippingMethod).HasName("PRIMARY");

			entity
				.ToTable("shipping_methods")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdShippingMethod)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_shipping_method");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("name");
			entity.Property(e => e.Price)
				.HasPrecision(10, 2)
				.HasColumnName("price");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<ShippingWeight>(entity =>
		{
			entity.HasKey(e => e.IdCourse).HasName("PRIMARY");

			entity
				.ToTable("shipping_weights")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdCourse)
				.ValueGeneratedNever()
				.HasColumnType("int(5)")
				.HasColumnName("id_course");
			entity.Property(e => e.Weight)
				.HasPrecision(5, 2)
				.HasColumnName("weight");
		});

		modelBuilder.Entity<StartDateChange>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("start_date_changes");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.ChangedBy)
				.HasColumnType("int(11)")
				.HasColumnName("changed_by");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.PreviousStartDate).HasColumnName("previous_start_date");
			entity.Property(e => e.Reason)
				.HasMaxLength(20)
				.HasColumnName("reason");
		});

		modelBuilder.Entity<State>(entity =>
		{
			entity.HasKey(e => e.IdState).HasName("PRIMARY");

			entity
				.ToTable("states")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCountry, "id_country_states");

			entity.Property(e => e.IdState)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_state");
			entity.Property(e => e.Abbreviation)
				.IsRequired()
				.HasMaxLength(8)
				.HasColumnName("abbreviation");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdCountry)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_country");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCountryNavigation).WithMany(p => p.States)
				.HasForeignKey(d => d.IdCountry)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_country_states");
		});

		modelBuilder.Entity<StudentOrganization>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("student_organizations");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.OrganizationName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("organization_name");
		});

		modelBuilder.Entity<StudentType>(entity =>
		{
			entity.HasKey(e => e.IdStudentType).HasName("PRIMARY");

			entity
				.ToTable("student_types")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.Seq, "seq");

			entity.Property(e => e.IdStudentType)
				.ValueGeneratedNever()
				.HasColumnType("int(11)")
				.HasColumnName("id_student_type");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnName("name");
			entity.Property(e => e.Seq)
				.HasColumnType("int(11)")
				.HasColumnName("seq");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<SubjectOutline>(entity =>
		{
			entity.HasKey(e => e.IdSubjectOutline).HasName("PRIMARY");

			entity.ToTable("subject_outlines");

			entity.HasIndex(e => e.IdOutlineClassification, "fk_subject_outlines_classifications");

			entity.HasIndex(e => new { e.Name, e.IdOutlineClassification }, "name_classification_id").IsUnique();

			entity.HasIndex(e => e.Active, "subject_outlines_active");

			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Description)
				.IsRequired()
				.HasColumnType("mediumtext")
				.HasColumnName("description");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.SubjectOutlines)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_subject_outlines_classifications");
		});

		modelBuilder.Entity<Core.Entities.Task>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("tasks");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.IdOutlineClassification, "id_outline_classification");

			entity.HasIndex(e => e.Active, "tasks_active");

			entity.HasIndex(e => e.TaskType, "tasks_task_type_index");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.ExcludeFromDirected).HasColumnName("exclude_from_directed");
			entity.Property(e => e.FixedDate).HasColumnName("fixed_date");
			entity.Property(e => e.HoursDuration).HasColumnName("hours_duration");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdOutlineClassification)
				.HasComment("foreign key for classifications")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.TaskType)
				.HasColumnType("enum('video','subject_outline','multiple','essay','essay_exam','performance_test','short_answer','graded_essay','milestone_exam','review','intermittent_quiz','drill','uworld_mbe_qbank')")
				.HasColumnName("task_type");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.Tasks)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course");

			entity.HasOne(d => d.IdOutlineClassificationNavigation).WithMany(p => p.Tasks)
				.HasForeignKey(d => d.IdOutlineClassification)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("tasks_ibfk_1");
		});

		modelBuilder.Entity<TaskEssaysSubjectOutline>(entity =>
		{
			entity.HasKey(e => new { e.IdTaskEssay, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("task_essays_subject_outlines");

			entity.HasIndex(e => e.IdSubjectOutline, "id_subject_outline");

			entity.HasIndex(e => e.IdTaskEssay, "id_task_essay");

			entity.HasIndex(e => e.Active, "task_essays_subject_outlines_active");

			entity.Property(e => e.IdTaskEssay)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_essay");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<TaskEvent>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("task_events");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse, e.EventType, e.EventDate }, "events_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.EmailDate).HasColumnName("email_date");
			entity.Property(e => e.EmailSent)
				.HasDefaultValueSql("'0'")
				.HasColumnName("email_sent");
			entity.Property(e => e.EventDate).HasColumnName("event_date");
			entity.Property(e => e.EventType)
				.IsRequired()
				.HasMaxLength(63)
				.HasColumnName("event_type");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdTask)
				.HasColumnType("int(11)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("int(11)")
				.HasColumnName("id_user");
			entity.Property(e => e.UserEventDate).HasColumnName("user_event_date");
		});

		modelBuilder.Entity<TaskOverride>(entity =>
		{
			entity.HasKey(e => new { e.IdReg, e.TaskType })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("task_overrides");

			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.TaskType)
				.HasMaxLength(64)
				.HasColumnName("task_type");
			entity.Property(e => e.CharacterLimit)
				.HasColumnType("int(11)")
				.HasColumnName("character_limit");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.QuestionTime).HasColumnName("question_time");
			entity.Property(e => e.RequiredScore).HasColumnName("required_score");
			entity.Property(e => e.TaskTime).HasColumnName("task_time");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdRegNavigation).WithMany(p => p.TaskOverrides)
				.HasForeignKey(d => d.IdReg)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_task_overrides_id_reg");
		});

		modelBuilder.Entity<TaskSchedule>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("task_schedules");

			entity.Property(e => e.IdTask)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.AvailableEnd)
				.HasColumnType("datetime")
				.HasColumnName("available_end");
			entity.Property(e => e.AvailableStart)
				.HasColumnType("datetime")
				.HasColumnName("available_start");
			entity.Property(e => e.FixedDatetime)
				.HasColumnType("datetime")
				.HasColumnName("fixed_datetime");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TaskSchedule)
				.HasForeignKey<TaskSchedule>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_task_schedules_id_task");
		});

		modelBuilder.Entity<TaskSettingDefault>(entity =>
		{
			entity
				.HasNoKey()
				.ToTable("task_setting_defaults");

			entity.HasIndex(e => e.IdCourse, "index_task_setting_defaults_on_id_course").IsUnique();

			entity.Property(e => e.DrillTaskIntro)
				.HasColumnType("text")
				.HasColumnName("drill_task_intro");
			entity.Property(e => e.EssayCharacterLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("essay_character_limit");
			entity.Property(e => e.EssayExamCharacterLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("essay_exam_character_limit");
			entity.Property(e => e.EssayExamIntro)
				.HasColumnType("text")
				.HasColumnName("essay_exam_intro");
			entity.Property(e => e.EssayExamTimeLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("essay_exam_time_limit");
			entity.Property(e => e.EssayIntro)
				.HasColumnType("text")
				.HasColumnName("essay_intro");
			entity.Property(e => e.EssayTimeLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("essay_time_limit");
			entity.Property(e => e.GradedEssayCharacterLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("graded_essay_character_limit");
			entity.Property(e => e.GradedEssayIntro)
				.HasColumnType("text")
				.HasColumnName("graded_essay_intro");
			entity.Property(e => e.GradedEssayRange)
				.HasColumnType("smallint(6)")
				.HasColumnName("graded_essay_range");
			entity.Property(e => e.GradedEssayTimeLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("graded_essay_time_limit");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IntermittentQuizIntro)
				.HasColumnType("text")
				.HasColumnName("intermittent_quiz_intro");
			entity.Property(e => e.MilestoneExamIntro)
				.HasColumnType("text")
				.HasColumnName("milestone_exam_intro");
			entity.Property(e => e.MilestoneExamRequiredScore)
				.HasColumnType("smallint(6)")
				.HasColumnName("milestone_exam_required_score");
			entity.Property(e => e.MultipleChoiceIntro)
				.HasColumnType("text")
				.HasColumnName("multiple_choice_intro");
			entity.Property(e => e.MultipleChoiceRequiredScore)
				.HasColumnType("smallint(6)")
				.HasColumnName("multiple_choice_required_score");
			entity.Property(e => e.MultipleChoiceTimeLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("multiple_choice_time_limit");
			entity.Property(e => e.ShortAnswerCharacterLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("short_answer_character_limit");
			entity.Property(e => e.ShortAnswerIntro)
				.HasColumnType("text")
				.HasColumnName("short_answer_intro");
			entity.Property(e => e.ShortAnswerTimeLimit)
				.HasColumnType("smallint(6)")
				.HasColumnName("short_answer_time_limit");
			entity.Property(e => e.UworldMbeQbankIntro)
				.HasColumnType("text")
				.HasColumnName("uworld_mbe_qbank_intro");
		});

		modelBuilder.Entity<TaskTypeTip>(entity =>
		{
			entity.HasKey(e => e.IdCourseTip).HasName("PRIMARY");

			entity.ToTable("task_type_tips");

			entity.Property(e => e.IdCourseTip)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_tip");
			entity.Property(e => e.Body)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("body");
			entity.Property(e => e.TaskType)
				.IsRequired()
				.HasColumnType("enum('video','subject_outline','multiple','essay','essay_exam','performance_test','short_answer','graded_essay','milestone_exam','review','intermittent_quiz')")
				.HasColumnName("task_type");
			entity.Property(e => e.Title)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("title");

			entity.HasOne(d => d.IdCourseTipNavigation).WithOne(p => p.TaskTypeTip)
				.HasForeignKey<TaskTypeTip>(d => d.IdCourseTip)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_course_tip_task_type_tips");
		});

		modelBuilder.Entity<TasksDrill>(entity =>
		{
			entity.HasKey(e => new { e.IdTask, e.IdDrillSet })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("tasks_drills");

			entity.HasIndex(e => e.IdDrillSet, "fk_tasks_drills_id_drill_set");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdDrillSet)
				.HasColumnType("int(11)")
				.HasColumnName("id_drill_set");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdDrillSetNavigation).WithMany(p => p.TasksDrills)
				.HasForeignKey(d => d.IdDrillSet)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_tasks_drills_id_drill_set");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TasksDrills)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_tasks_drills_id_task");
		});

		modelBuilder.Entity<TasksEssay>(entity =>
		{
			entity.HasKey(e => e.IdTaskEssay).HasName("PRIMARY");

			entity.ToTable("tasks_essays");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "tasks_essays_active");

			entity.Property(e => e.IdTaskEssay)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_essay");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.NumberOfQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("number_of_questions");
			entity.Property(e => e.QuestionCharacterLimit)
				.HasColumnType("int(11)")
				.HasColumnName("question_character_limit");
			entity.Property(e => e.QuestionTimeLimit)
				.HasColumnType("int(11)")
				.HasColumnName("question_time_limit");
			entity.Property(e => e.ScoresRange).HasColumnName("scores_range");
			entity.Property(e => e.TotalTime).HasColumnName("total_time");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TasksEssays)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_tskess");
		});

		modelBuilder.Entity<TasksEssaysQuestion>(entity =>
		{
			entity.HasKey(e => new { e.IdTaskEssay, e.IdEssayQuestion })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("tasks_essays_questions");

			entity.HasIndex(e => e.IdEssayQuestion, "id_subject_outline");

			entity.HasIndex(e => e.IdTaskEssay, "id_task_essay");

			entity.HasIndex(e => e.Active, "tasks_essays_questions_active");

			entity.Property(e => e.IdTaskEssay)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_essay");
			entity.Property(e => e.IdEssayQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_essay_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Position)
				.HasColumnType("tinyint(4)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdEssayQuestionNavigation).WithMany(p => p.TasksEssaysQuestions)
				.HasForeignKey(d => d.IdEssayQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_written_question");
		});

		modelBuilder.Entity<TasksIntermittentQuize>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("tasks_intermittent_quizes");

			entity.HasIndex(e => e.IdSubjectOutline, "id_subject_outline");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.Property(e => e.IdTask)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.TasksIntermittentQuizes)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_subject_outline_iqs");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksIntermittentQuize)
				.HasForeignKey<TasksIntermittentQuize>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_iqs");
		});

		modelBuilder.Entity<TasksLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdTask, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("tasks_learners");

			entity.HasIndex(e => e.IdUser, "fk_tasks_learners_learners1");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => new { e.IdTask, e.IdUser }, "id_user_task");

			entity.HasIndex(e => e.Active, "tasks_learners_active");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.CompletedDatetime)
				.HasColumnType("datetime")
				.HasColumnName("completed_datetime");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.TaskDate).HasColumnName("task_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TasksLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_tasks_learners_learners1");
		});

		modelBuilder.Entity<TasksMilestone>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("tasks_milestones");

			entity.HasIndex(e => e.IdMilestoneExam, "id_milestone_exam");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "tasks_milestones_active");

			entity.Property(e => e.IdTask)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdMilestoneExam)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_milestone_exam");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.RequiredScore).HasColumnName("required_score");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdMilestoneExamNavigation).WithMany(p => p.TasksMilestones)
				.HasForeignKey(d => d.IdMilestoneExam)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_milestone_exam");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksMilestone)
				.HasForeignKey<TasksMilestone>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_miles");
		});

		modelBuilder.Entity<TasksMultipleChoice>(entity =>
		{
			entity.HasKey(e => e.IdTaskMultipleChoice).HasName("PRIMARY");

			entity.ToTable("tasks_multiple_choices");

			entity.HasIndex(e => e.IdTask, "id_task").IsUnique();

			entity.HasIndex(e => e.Active, "tasks_multiple_choices_active");

			entity.Property(e => e.IdTaskMultipleChoice)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_multiple_choice");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdMultipleChoiceSet)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_multiple_choice_set");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.NumberOfQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("number_of_questions");
			entity.Property(e => e.RequiredScorePercentage).HasColumnName("required_score_percentage");
			entity.Property(e => e.TimePerQuestion).HasColumnName("time_per_question");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksMultipleChoice)
				.HasForeignKey<TasksMultipleChoice>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_multch");
		});

		modelBuilder.Entity<TasksMultipleChoiceSubject>(entity =>
		{
			entity.HasKey(e => new { e.IdSubjectOutline, e.IdChapter, e.IdTaskMultipleChoice })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("tasks_multiple_choice_subjects");

			entity.HasIndex(e => e.IdTaskMultipleChoice, "id_task_multiple_choice");

			entity.HasIndex(e => e.Active, "tasks_multiple_choice_subjects_active");

			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.IdTaskMultipleChoice)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_multiple_choice");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.TasksMultipleChoiceSubjects)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_subject_outline_muchosub");

			entity.HasOne(d => d.IdTaskMultipleChoiceNavigation).WithMany(p => p.TasksMultipleChoiceSubjects)
				.HasForeignKey(d => d.IdTaskMultipleChoice)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_multiple_choice_muchosub");
		});

		modelBuilder.Entity<TasksPerformanceTest>(entity =>
		{
			entity.HasKey(e => e.IdTask).HasName("PRIMARY");

			entity.ToTable("tasks_performance_tests");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "tasks_performance_tests_active");

			entity.Property(e => e.IdTask)
				.ValueGeneratedNever()
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.CharacterCount)
				.HasColumnType("bigint(20)")
				.HasColumnName("character_count");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.ModelAnswer)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("model_answer");
			entity.Property(e => e.PdfEssayS3Url)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("pdf_essay_s3_url");
			entity.Property(e => e.TimeLimit).HasColumnName("time_limit");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksPerformanceTest)
				.HasForeignKey<TasksPerformanceTest>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_perftests");
		});

		modelBuilder.Entity<TasksReview>(entity =>
		{
			entity.HasKey(e => e.IdTaskReview).HasName("PRIMARY");

			entity.ToTable("tasks_reviews");

			entity.HasIndex(e => e.IdTask, "id_task").IsUnique();

			entity.HasIndex(e => e.Active, "tasks_reviews");

			entity.Property(e => e.IdTaskReview)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_review");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksReview)
				.HasForeignKey<TasksReview>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_rev");
		});

		modelBuilder.Entity<TasksSubjectOutline>(entity =>
		{
			entity.HasKey(e => new { e.IdTask, e.IdChapter })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("tasks_subject_outlines");

			entity.HasIndex(e => e.IdChapter, "id_chapter");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "tasks_subject_outlines_active");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdChapterNavigation).WithMany(p => p.TasksSubjectOutlines)
				.HasForeignKey(d => d.IdChapter)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_chapter");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TasksSubjectOutlines)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_subject_out");
		});

		modelBuilder.Entity<TasksUworldMbeQbank>(entity =>
		{
			entity.HasKey(e => e.IdTaskUworldMbeQbank).HasName("PRIMARY");

			entity.ToTable("tasks_uworld_mbe_qbank");

			entity.HasIndex(e => e.IdTask, "id_task").IsUnique();

			entity.Property(e => e.IdTaskUworldMbeQbank)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task_uworld_mbe_qbank");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IntroMessage)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("intro_message");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithOne(p => p.TasksUworldMbeQbank)
				.HasForeignKey<TasksUworldMbeQbank>(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_uworld_mbe_qbank");
		});

		modelBuilder.Entity<TasksVideo>(entity =>
		{
			entity.HasKey(e => new { e.IdTask, e.IdVideo })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("tasks_videos");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.IdVideo, "id_video");

			entity.HasIndex(e => e.Active, "tasks_videos_active");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TasksVideos)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_task_vidtsk");

			entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.TasksVideos)
				.HasForeignKey(d => d.IdVideo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("id_video_vidtsk");
		});

		modelBuilder.Entity<TasksVideosLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdTask, e.IdVideo, e.IdUser })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("tasks_videos_learners");

			entity.HasIndex(e => e.IdUser, "fk_tasks_videos_learners_learners1");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.IdVideo, "id_video");

			entity.HasIndex(e => e.Active, "tasks_videos_learners_active");

			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Score).HasColumnName("score");
			entity.Property(e => e.State)
				.IsRequired()
				.HasColumnType("enum('mastered','complete','incomplete')")
				.HasColumnName("state");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TasksVideosLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_tasks_videos_learners_learners1");
		});

		modelBuilder.Entity<TaxByState>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("tax_by_state");

			entity.Property(e => e.Id)
				.HasColumnType("bigint(20)")
				.HasColumnName("id");
			entity.Property(e => e.IdState)
				.HasColumnType("int(11)")
				.HasColumnName("id_state");
			entity.Property(e => e.PartialAmount)
				.HasColumnType("bigint(20)")
				.HasColumnName("partial_amount");
			entity.Property(e => e.Shipping).HasColumnName("shipping");
			entity.Property(e => e.Tuition)
				.HasColumnType("enum('full','partial','none')")
				.HasColumnName("tuition");
		});

		modelBuilder.Entity<TaxRate>(entity =>
		{
			entity.HasKey(e => e.IdTaxRate).HasName("PRIMARY");

			entity.ToTable("tax_rate");

			entity.HasIndex(e => e.IdState, "index_tax_rate_on_id_state");

			entity.HasIndex(e => e.ZipCode, "zip_code");

			entity.Property(e => e.IdTaxRate)
				.HasColumnType("int(11)")
				.HasColumnName("id_tax_rate");
			entity.Property(e => e.Country)
				.HasMaxLength(20)
				.HasColumnName("country");
			entity.Property(e => e.IdState)
				.HasColumnType("int(11)")
				.HasColumnName("id_state");
			entity.Property(e => e.OnCourse).HasColumnName("on_course");
			entity.Property(e => e.StateCode)
				.IsRequired()
				.HasMaxLength(2)
				.HasColumnName("state_code");
			entity.Property(e => e.Tax)
				.HasPrecision(10, 9)
				.HasColumnName("tax");
			entity.Property(e => e.TaxYear)
				.HasColumnType("int(11)")
				.HasColumnName("tax_year");
			entity.Property(e => e.ZipCode)
				.HasColumnType("int(11)")
				.HasColumnName("zip_code");
		});

		modelBuilder.Entity<Testimonial>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("testimonials")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.UsStateCode, "index_testimonials_on_us_state_code");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.City)
				.HasMaxLength(50)
				.HasColumnName("city");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.PrimaryHeadshotImagePath)
				.HasMaxLength(255)
				.HasColumnName("primary_headshot_image_path");
			entity.Property(e => e.Quote)
				.HasColumnType("text")
				.HasColumnName("quote");
			entity.Property(e => e.School)
				.HasMaxLength(100)
				.HasColumnName("school");
			entity.Property(e => e.Speaker)
				.HasMaxLength(60)
				.HasColumnName("speaker");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UsStateCode)
				.HasMaxLength(2)
				.HasColumnName("us_state_code");
			entity.Property(e => e.Weight)
				.HasColumnType("int(11)")
				.HasColumnName("weight");
		});

		modelBuilder.Entity<ThemisToUworldMcq>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("themis_to_uworld_mcq")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AnswerChoiceList)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("answer_choice_list");
			entity.Property(e => e.ChangeTypeId)
				.HasMaxLength(10)
				.HasColumnName("change_type_id");
			entity.Property(e => e.ClassificationId)
				.HasColumnType("int(11)")
				.HasColumnName("classification_id");
			entity.Property(e => e.CorrectAnswerId)
				.HasColumnType("bigint(20)")
				.HasColumnName("correct_answer_id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.DateModified)
				.HasMaxLength(10)
				.HasColumnName("date_modified");
			entity.Property(e => e.DefinitionList)
				.HasColumnType("text")
				.HasColumnName("definition_list");
			entity.Property(e => e.ErrorMessage)
				.HasColumnType("text")
				.HasColumnName("error_message");
			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.IdSection)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_section");
			entity.Property(e => e.IdSubject)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject");
			entity.Property(e => e.IsProcessed).HasColumnName("is_processed");
			entity.Property(e => e.Media)
				.HasColumnType("text")
				.HasColumnName("media");
			entity.Property(e => e.ProcessedAt)
				.HasColumnType("datetime")
				.HasColumnName("processed_at");
			entity.Property(e => e.ProcessedBy)
				.HasColumnType("bigint(20)")
				.HasColumnName("processed_by");
			entity.Property(e => e.Published).HasColumnName("published");
			entity.Property(e => e.QuestionRationale)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_rationale");
			entity.Property(e => e.QuestionStem)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_stem");
			entity.Property(e => e.QuestionTitle)
				.HasColumnType("text")
				.HasColumnName("question_title");
			entity.Property(e => e.Success)
				.HasColumnType("int(11)")
				.HasColumnName("success");
			entity.Property(e => e.ThemisQuestionId)
				.HasColumnType("bigint(20)")
				.HasColumnName("themis_question_id");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UworldQuestionId)
				.HasColumnType("int(11)")
				.HasColumnName("uworld_question_id");
		});

		modelBuilder.Entity<Core.Entities.TimeZone>(entity =>
		{
			entity.HasKey(e => e.IdTimeZone).HasName("PRIMARY");

			entity.ToTable("time_zones");

			entity.Property(e => e.IdTimeZone)
				.HasColumnType("int(11)")
				.HasColumnName("id_time_zone");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.FriendlyName)
				.HasMaxLength(255)
				.HasColumnName("friendly_name");
			entity.Property(e => e.SystemName)
				.HasMaxLength(255)
				.HasColumnName("system_name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Track>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("tracks")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.IdCourse, "IDX_246D2A2E30A9DA54");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.AccessBegin)
				.HasDefaultValueSql("'0000-00-00 00:00:00'")
				.HasColumnType("datetime")
				.HasColumnName("access_begin");
			entity.Property(e => e.AccessEnd)
				.HasDefaultValueSql("'0000-00-00 00:00:00'")
				.HasColumnType("datetime")
				.HasColumnName("access_end");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.DisplayName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("display_name");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.RecommendedDisplay)
				.HasColumnType("datetime")
				.HasColumnName("recommended_display");
			entity.Property(e => e.ScheduleEnd)
				.HasColumnType("datetime")
				.HasColumnName("schedule_end");
			entity.Property(e => e.ScheduleStart)
				.HasColumnType("datetime")
				.HasColumnName("schedule_start");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.Tracks)
				.HasForeignKey(d => d.IdCourse)
				.HasConstraintName("FK_246D2A2E30A9DA54");
		});

		modelBuilder.Entity<TrackSchedule>(entity =>
		{
			entity.HasKey(e => new { e.IdTrack, e.IdCourseSchedule })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("track_schedules")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.IdCourseSchedule, "IDX_3083727A1AD2BF25");

			entity.HasIndex(e => e.IdTrack, "IDX_3083727A3866B996");

			entity.Property(e => e.IdTrack)
				.HasColumnType("int(11)")
				.HasColumnName("id_track");
			entity.Property(e => e.IdCourseSchedule)
				.HasColumnType("int(11)")
				.HasColumnName("id_course_schedule");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdCourseScheduleNavigation).WithMany(p => p.TrackSchedules)
				.HasForeignKey(d => d.IdCourseSchedule)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_3083727A1AD2BF25");

			entity.HasOne(d => d.IdTrackNavigation).WithMany(p => p.TrackSchedules)
				.HasForeignKey(d => d.IdTrack)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_3083727A3866B996");
		});

		modelBuilder.Entity<TrackTask>(entity =>
		{
			entity.HasKey(e => new { e.IdTrack, e.IdTask })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("track_tasks")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.IdTrack, "IDX_20AFC7303866B996");

			entity.HasIndex(e => e.IdTask, "IDX_20AFC730D95EC727");

			entity.Property(e => e.IdTrack)
				.HasColumnType("int(11)")
				.HasColumnName("id_track");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.AvailableEnd)
				.HasColumnType("datetime")
				.HasColumnName("available_end");
			entity.Property(e => e.AvailableStart)
				.HasColumnType("datetime")
				.HasColumnName("available_start");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ExcludeFromDirected).HasColumnName("exclude_from_directed");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.Scheduled).HasColumnName("scheduled");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TrackTasks)
				.HasForeignKey(d => d.IdTask)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_20AFC730D95EC727");

			entity.HasOne(d => d.IdTrackNavigation).WithMany(p => p.TrackTasks)
				.HasForeignKey(d => d.IdTrack)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_20AFC7303866B996");
		});

		modelBuilder.Entity<Transaction>(entity =>
		{
			entity.HasKey(e => e.IdTransaction).HasName("PRIMARY");

			entity.ToTable("transactions");

			entity.HasIndex(e => e.IdBillingInvoice, "id_billing_invoice");

			entity.HasIndex(e => e.AccountingYear, "index_transactions_on_accounting_year");

			entity.HasIndex(e => e.AuthorizedBy, "index_transactions_on_authorized_by");

			entity.HasIndex(e => e.IdAddon, "index_transactions_on_id_addon");

			entity.HasIndex(e => e.IdAdjustmentCategory, "index_transactions_on_id_adjustment_category");

			entity.HasIndex(e => e.IdBilling, "index_transactions_on_id_billing");

			entity.HasIndex(e => e.IdDiscountCategory, "index_transactions_on_id_discount_category");

			entity.HasIndex(e => e.IdPaymentInformation, "index_transactions_on_id_payment_information");

			entity.HasIndex(e => e.IdPromoType, "index_transactions_on_id_promos");

			entity.HasIndex(e => e.IdRefundInformation, "index_transactions_on_id_refund_information");

			entity.HasIndex(e => e.IdReg, "index_transactions_on_id_reg");

			entity.HasIndex(e => e.Mode, "index_transactions_on_mode");

			entity.HasIndex(e => e.RequestedBy, "index_transactions_on_requested_by");

			entity.HasIndex(e => e.Type, "index_transactions_on_type");

			entity.Property(e => e.IdTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_transaction");
			entity.Property(e => e.AccountingYear)
				.HasColumnType("int(11)")
				.HasColumnName("accounting_year");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.AuthorizedBy)
				.HasColumnType("int(11)")
				.HasColumnName("authorized_by");
			entity.Property(e => e.BillPayDate)
				.HasColumnType("datetime")
				.HasColumnName("bill_pay_date");
			entity.Property(e => e.Date)
				.HasColumnType("datetime")
				.HasColumnName("date");
			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.IdAdjustmentCategory)
				.HasColumnType("int(11)")
				.HasColumnName("id_adjustment_category");
			entity.Property(e => e.IdBilling)
				.HasColumnType("int(11)")
				.HasColumnName("id_billing");
			entity.Property(e => e.IdBillingInvoice)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_billing_invoice");
			entity.Property(e => e.IdDiscountCategory)
				.HasColumnType("int(11)")
				.HasColumnName("id_discount_category");
			entity.Property(e => e.IdPaymentInformation)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_information");
			entity.Property(e => e.IdPromoConditional)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_conditional");
			entity.Property(e => e.IdPromoType)
				.HasColumnType("int(11)")
				.HasColumnName("id_promo_type");
			entity.Property(e => e.IdRefundInformation)
				.HasColumnType("int(11)")
				.HasColumnName("id_refund_information");
			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.Mode)
				.IsRequired()
				.HasMaxLength(11)
				.HasColumnName("mode");
			entity.Property(e => e.RequestedBy)
				.HasColumnType("int(11)")
				.HasColumnName("requested_by");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(7)
				.HasColumnName("type");
		});

		modelBuilder.Entity<TransactionsAddon>(entity =>
		{
			entity.HasKey(e => e.IdTransaction).HasName("PRIMARY");

			entity.ToTable("transactions_addons");

			entity.HasIndex(e => e.IdAddon, "fk_transactions_addons_id_addon");

			entity.Property(e => e.IdTransaction)
				.HasColumnType("int(11)")
				.HasColumnName("id_transaction");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.Subtype)
				.IsRequired()
				.HasMaxLength(25)
				.HasColumnName("subtype");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<TransactionsAffirm>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("transactions_affirm");

			entity.HasIndex(e => e.OrderId, "transactions_affirm_order_index");

			entity.HasIndex(e => e.TransactionType, "transactions_affirm_type_index");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.AuthMerchantTranId)
				.HasMaxLength(30)
				.HasColumnName("auth_merchant_tran_id");
			entity.Property(e => e.AuthTranAt)
				.HasColumnType("datetime")
				.HasColumnName("auth_tran_at");
			entity.Property(e => e.AuthTranId)
				.HasMaxLength(30)
				.HasColumnName("auth_tran_id");
			entity.Property(e => e.ChargeId)
				.HasMaxLength(30)
				.HasColumnName("charge_id");
			entity.Property(e => e.ChargeMerchantTranId)
				.HasMaxLength(30)
				.HasColumnName("charge_merchant_tran_id");
			entity.Property(e => e.ChargeTranAt)
				.HasColumnType("datetime")
				.HasColumnName("charge_tran_at");
			entity.Property(e => e.ChargeTranId)
				.HasMaxLength(30)
				.HasColumnName("charge_tran_id");
			entity.Property(e => e.CheckoutToken)
				.HasMaxLength(30)
				.HasColumnName("checkout_token");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Currency)
				.HasMaxLength(10)
				.HasColumnName("currency");
			entity.Property(e => e.CustomerId)
				.IsRequired()
				.HasMaxLength(30)
				.HasColumnName("customer_id");
			entity.Property(e => e.FeeAmount)
				.HasPrecision(10, 2)
				.HasColumnName("fee_amount");
			entity.Property(e => e.OrderId)
				.IsRequired()
				.HasMaxLength(15)
				.HasColumnName("order_id");
			entity.Property(e => e.RefundAmount)
				.HasPrecision(10, 2)
				.HasColumnName("refund_amount");
			entity.Property(e => e.RefundTranAt)
				.HasColumnType("datetime")
				.HasColumnName("refund_tran_at");
			entity.Property(e => e.RefundTranId)
				.HasMaxLength(30)
				.HasColumnName("refund_tran_id");
			entity.Property(e => e.TransactionType)
				.IsRequired()
				.HasMaxLength(30)
				.HasColumnName("transaction_type");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.VoidTranAt)
				.HasColumnType("datetime")
				.HasColumnName("void_tran_at");
			entity.Property(e => e.VoidTranId)
				.HasMaxLength(30)
				.HasColumnName("void_tran_id");
		});

		modelBuilder.Entity<TransactionsPaytrace>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("transactions_paytrace");

			entity.HasIndex(e => e.OrderId, "paytrace_id");

			entity.HasIndex(e => e.Type, "type");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("ID");
			entity.Property(e => e.Amount)
				.HasPrecision(10, 2)
				.HasColumnName("amount");
			entity.Property(e => e.Appcode)
				.IsRequired()
				.HasMaxLength(15)
				.HasColumnName("appcode");
			entity.Property(e => e.Appmsg)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("appmsg");
			entity.Property(e => e.AuthKey)
				.HasColumnType("int(11)")
				.HasColumnName("auth_key");
			entity.Property(e => e.Avsresponse)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("avsresponse");
			entity.Property(e => e.Bname)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("bname");
			entity.Property(e => e.CardType)
				.HasMaxLength(10)
				.HasColumnName("card_type");
			entity.Property(e => e.Cscresponse)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("cscresponse");
			entity.Property(e => e.CustomerId)
				.HasMaxLength(30)
				.HasColumnName("customer_id");
			entity.Property(e => e.Datetime)
				.HasColumnType("datetime")
				.HasColumnName("datetime");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("email");
			entity.Property(e => e.Error)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("error");
			entity.Property(e => e.Expmnth)
				.HasColumnType("tinyint(4)")
				.HasColumnName("expmnth");
			entity.Property(e => e.Expyr)
				.HasColumnType("tinyint(4)")
				.HasColumnName("expyr");
			entity.Property(e => e.First4)
				.HasColumnType("int(11)")
				.HasColumnName("first4");
			entity.Property(e => e.Last4)
				.HasColumnType("int(11)")
				.HasColumnName("last4");
			entity.Property(e => e.OrderId)
				.IsRequired()
				.HasMaxLength(15)
				.HasColumnName("order_id");
			entity.Property(e => e.RefundedTransactionId)
				.HasColumnType("int(11)")
				.HasColumnName("refunded_transaction_id");
			entity.Property(e => e.ReturnUrl)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("return_url");
			entity.Property(e => e.Status).HasColumnName("status");
			entity.Property(e => e.TransactionId)
				.HasColumnType("int(11)")
				.HasColumnName("transaction_id");
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(7)
				.HasColumnName("type");
		});

		modelBuilder.Entity<TransactionsTotal>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("transactions_totals");

			entity.HasIndex(e => e.Access, "access");

			entity.HasIndex(e => e.CourseYear, "course_year");

			entity.HasIndex(e => e.PfFree, "free_course");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.IdCourseType, "id_course_type");

			entity.HasIndex(e => e.IdLawSchool, "id_law_school");

			entity.HasIndex(e => e.IdOutlineClassification, "id_outline_classification");

			entity.HasIndex(e => e.IdReg, "id_reg");

			entity.HasIndex(e => e.IdSeason, "id_season");

			entity.HasIndex(e => e.OnReports, "on_reports");

			entity.HasIndex(e => e.OutlineClassificationDescription, "outline_classification_description");

			entity.HasIndex(e => e.PartialAbove, "partial_above");

			entity.HasIndex(e => e.PartialBelow, "partial_below");

			entity.HasIndex(e => e.PfBelow, "pd_below");

			entity.HasIndex(e => e.PfAbove, "pf_above");

			entity.HasIndex(e => e.Registered, "registered");

			entity.HasIndex(e => e.SeasonAbv, "season_abv");

			entity.HasIndex(e => e.UnpaidFirm, "unpaid_firm");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Access)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("access");
			entity.Property(e => e.BalanceDue)
				.HasPrecision(10, 2)
				.HasColumnName("balance_due");
			entity.Property(e => e.BalanceDueBilling)
				.HasPrecision(10, 2)
				.HasColumnName("balance_due_billing");
			entity.Property(e => e.CourseYear)
				.HasColumnType("int(11)")
				.HasColumnName("course_year");
			entity.Property(e => e.Floor)
				.HasPrecision(10, 2)
				.HasColumnName("floor");
			entity.Property(e => e.FloorMet).HasColumnName("floor_met");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdCourseType)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course_type");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.IdPaymentPlan)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_plan");
			entity.Property(e => e.IdReg)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdSeason)
				.HasColumnType("int(11)")
				.HasColumnName("id_season");
			entity.Property(e => e.LaunchOverwrite).HasColumnName("launch_overwrite");
			entity.Property(e => e.MaxPromo)
				.HasPrecision(10, 2)
				.HasColumnName("max_promo");
			entity.Property(e => e.OnReports)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("on_reports");
			entity.Property(e => e.OutlineClassificationDescription)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("outline_classification_description");
			entity.Property(e => e.PaidInFull).HasColumnName("paid_in_full");
			entity.Property(e => e.PaidInFullBilling).HasColumnName("paid_in_full_billing");
			entity.Property(e => e.PartialAbove).HasColumnName("partial_above");
			entity.Property(e => e.PartialBelow).HasColumnName("partial_below");
			entity.Property(e => e.Payment).HasColumnName("payment");
			entity.Property(e => e.PfAbove).HasColumnName("pf_above");
			entity.Property(e => e.PfBelow).HasColumnName("pf_below");
			entity.Property(e => e.PfFree).HasColumnName("pf_free");
			entity.Property(e => e.RegType)
				.IsRequired()
				.HasDefaultValueSql("'1'")
				.HasColumnName("reg_type");
			entity.Property(e => e.Registered).HasColumnName("registered");
			entity.Property(e => e.SeasonAbv)
				.IsRequired()
				.HasMaxLength(5)
				.HasColumnName("season_abv");
			entity.Property(e => e.TaxExempt)
				.HasPrecision(10, 2)
				.HasColumnName("tax_exempt");
			entity.Property(e => e.TotalAdjustments)
				.HasPrecision(10, 2)
				.HasColumnName("total_adjustments");
			entity.Property(e => e.TotalBilled)
				.HasPrecision(10, 2)
				.HasColumnName("total_billed");
			entity.Property(e => e.TotalPaid)
				.HasPrecision(10, 2)
				.HasColumnName("total_paid");
			entity.Property(e => e.TotalPayment)
				.HasPrecision(10, 2)
				.HasColumnName("total_payment");
			entity.Property(e => e.TotalPromo)
				.HasPrecision(10, 2)
				.HasColumnName("total_promo");
			entity.Property(e => e.TotalRefunded)
				.HasPrecision(10, 2)
				.HasColumnName("total_refunded");
			entity.Property(e => e.Tuition)
				.HasPrecision(10, 2)
				.HasColumnName("tuition");
			entity.Property(e => e.UnpaidFirm).HasColumnName("unpaid_firm");
		});

		modelBuilder.Entity<TransactionsTotalsAddon>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("transactions_totals_addons");

			entity.HasIndex(e => e.CourseYear, "course_year");

			entity.HasIndex(e => e.IdAddon, "id_addon");

			entity.HasIndex(e => e.IdAddonType, "id_addon_type");

			entity.HasIndex(e => e.IdCourse, "id_course");

			entity.HasIndex(e => e.IdReg, "id_reg");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.BalanceDue)
				.HasPrecision(10, 2)
				.HasColumnName("balance_due");
			entity.Property(e => e.BalanceDueBilling)
				.HasPrecision(10, 2)
				.HasColumnName("balance_due_billing");
			entity.Property(e => e.CourseYear)
				.HasColumnType("int(11)")
				.HasColumnName("course_year");
			entity.Property(e => e.Fee)
				.HasPrecision(10, 2)
				.HasColumnName("fee");
			entity.Property(e => e.IdAddon)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon");
			entity.Property(e => e.IdAddonType)
				.HasColumnType("int(11)")
				.HasColumnName("id_addon_type");
			entity.Property(e => e.IdCourse)
				.HasColumnType("int(11)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdPaymentPlan)
				.HasColumnType("int(11)")
				.HasColumnName("id_payment_plan");
			entity.Property(e => e.IdReg)
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.PaidInFull).HasColumnName("paid_in_full");
			entity.Property(e => e.PaidInFullBilling).HasColumnName("paid_in_full_billing");
			entity.Property(e => e.TotalAdjustments)
				.HasPrecision(10, 2)
				.HasColumnName("total_adjustments");
			entity.Property(e => e.TotalBilled)
				.HasPrecision(10, 2)
				.HasColumnName("total_billed");
			entity.Property(e => e.TotalPaid)
				.HasPrecision(10, 2)
				.HasColumnName("total_paid");
			entity.Property(e => e.TotalPayment)
				.HasPrecision(10, 2)
				.HasColumnName("total_payment");
			entity.Property(e => e.TotalPromo)
				.HasPrecision(10, 2)
				.HasColumnName("total_promo");
			entity.Property(e => e.TotalRefunded)
				.HasPrecision(10, 2)
				.HasColumnName("total_refunded");
		});

		modelBuilder.Entity<UlawEnrollment>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("ulaw_enrollments")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Address1)
				.HasMaxLength(255)
				.HasColumnName("address_1");
			entity.Property(e => e.Address2)
				.HasMaxLength(255)
				.HasColumnName("address_2");
			entity.Property(e => e.City)
				.HasMaxLength(50)
				.HasColumnName("city");
			entity.Property(e => e.County)
				.HasMaxLength(50)
				.HasColumnName("county");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Email)
				.HasMaxLength(255)
				.HasColumnName("email");
			entity.Property(e => e.ExamDate).HasColumnName("exam_date");
			entity.Property(e => e.FirstName)
				.HasMaxLength(255)
				.HasColumnName("first_name");
			entity.Property(e => e.GraduationDate)
				.HasColumnType("datetime")
				.HasColumnName("graduation_date");
			entity.Property(e => e.IdCountry)
				.HasColumnType("int(11)")
				.HasColumnName("id_country");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("int(11)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.IdOutlineClassification)
				.HasColumnType("int(11)")
				.HasColumnName("id_outline_classification");
			entity.Property(e => e.LastName)
				.HasMaxLength(255)
				.HasColumnName("last_name");
			entity.Property(e => e.MpreExamDate).HasColumnName("mpre_exam_date");
			entity.Property(e => e.PostCode)
				.HasMaxLength(50)
				.HasColumnName("post_code");
			entity.Property(e => e.Program)
				.HasMaxLength(255)
				.HasColumnName("program");
			entity.Property(e => e.WantsMpre).HasColumnName("wants_mpre");
		});

		modelBuilder.Entity<UrlShortening>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("url_shortenings")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Description)
				.HasMaxLength(255)
				.HasColumnName("description");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.Url)
				.HasMaxLength(100)
				.HasColumnName("url");
			entity.Property(e => e.UtmCampaign)
				.HasMaxLength(100)
				.HasColumnName("utm_campaign");
			entity.Property(e => e.UtmContent)
				.HasMaxLength(100)
				.HasColumnName("utm_content");
			entity.Property(e => e.UtmMedium)
				.HasMaxLength(100)
				.HasColumnName("utm_medium");
			entity.Property(e => e.UtmSource)
				.HasMaxLength(100)
				.HasColumnName("utm_source");
			entity.Property(e => e.UtmTerm)
				.HasMaxLength(100)
				.HasColumnName("utm_term");
		});

		modelBuilder.Entity<UsState>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("us_states")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.BarDifficultyRank, "index_us_states_on_bar_difficulty_rank");

			entity.HasIndex(e => e.Code, "index_us_states_on_code").IsUnique();

			entity.HasIndex(e => e.Path, "index_us_states_on_path").IsUnique();

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.BannerNotice)
				.HasMaxLength(255)
				.HasColumnName("banner_notice");
			entity.Property(e => e.BarAssociationInitials)
				.HasColumnType("tinytext")
				.HasColumnName("bar_association_initials");
			entity.Property(e => e.BarDifficultyRank)
				.HasColumnType("int(11)")
				.HasColumnName("bar_difficulty_rank");
			entity.Property(e => e.BarExamFebruaryResultsMardownBlurb)
				.HasColumnType("text")
				.HasColumnName("bar_exam_february_results_mardown_blurb");
			entity.Property(e => e.BarExamFebruaryResultsYear)
				.HasColumnType("smallint(6)")
				.HasColumnName("bar_exam_february_results_year");
			entity.Property(e => e.BarExamJulyResultsMardownBlurb)
				.HasColumnType("text")
				.HasColumnName("bar_exam_july_results_mardown_blurb");
			entity.Property(e => e.BarExamJulyResultsYear)
				.HasColumnType("smallint(6)")
				.HasColumnName("bar_exam_july_results_year");
			entity.Property(e => e.BarExamLocalComponentDescriptionMarkdownBlurb)
				.HasColumnType("text")
				.HasColumnName("bar_exam_local_component_description_markdown_blurb");
			entity.Property(e => e.BarExamLocalComponentFormatMarkdownBlurb)
				.HasColumnType("text")
				.HasColumnName("bar_exam_local_component_format_markdown_blurb");
			entity.Property(e => e.BarExamLocalComponentName)
				.HasMaxLength(255)
				.HasColumnName("bar_exam_local_component_name");
			entity.Property(e => e.BarExamLocalComponentSubtitle)
				.HasMaxLength(255)
				.HasColumnName("bar_exam_local_component_subtitle");
			entity.Property(e => e.BarExamMetaKeywords)
				.HasColumnType("text")
				.HasColumnName("bar_exam_meta_keywords");
			entity.Property(e => e.BarExamTestSubjects)
				.HasColumnType("text")
				.HasColumnName("bar_exam_test_subjects");
			entity.Property(e => e.Code)
				.HasMaxLength(2)
				.HasColumnName("code");
			entity.Property(e => e.CourseOverviewCalendarDate).HasColumnName("course_overview_calendar_date");
			entity.Property(e => e.CourseOverviewCalendarUrl)
				.HasMaxLength(255)
				.HasColumnName("course_overview_calendar_url");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.HasBarReviewOffering).HasColumnName("has_bar_review_offering");
			entity.Property(e => e.HasMbeComponent).HasColumnName("has_mbe_component");
			entity.Property(e => e.HasMeeComponent)
				.HasDefaultValueSql("'0'")
				.HasColumnName("has_mee_component");
			entity.Property(e => e.HasMpreReviewOffering).HasColumnName("has_mpre_review_offering");
			entity.Property(e => e.HasMptComponent)
				.HasDefaultValueSql("'0'")
				.HasColumnName("has_mpt_component");
			entity.Property(e => e.IsUbe).HasColumnName("is_ube");
			entity.Property(e => e.MbeComponentSubtitle)
				.HasMaxLength(250)
				.HasColumnName("mbe_component_subtitle");
			entity.Property(e => e.MeeComponentMarkdownBlurb)
				.HasColumnType("text")
				.HasColumnName("mee_component_markdown_blurb");
			entity.Property(e => e.MeeComponentSubtitle)
				.HasMaxLength(250)
				.HasColumnName("mee_component_subtitle");
			entity.Property(e => e.MpreMetaKeywords)
				.HasColumnType("text")
				.HasColumnName("mpre_meta_keywords");
			entity.Property(e => e.MpreMinScore)
				.HasColumnType("int(11)")
				.HasColumnName("mpre_min_score");
			entity.Property(e => e.MptComponentSubtitle)
				.HasMaxLength(250)
				.HasColumnName("mpt_component_subtitle");
			entity.Property(e => e.Name)
				.HasMaxLength(50)
				.HasColumnName("name");
			entity.Property(e => e.NextBarExamDate).HasColumnName("next_bar_exam_date");
			entity.Property(e => e.NextBarExamLastFilingDeadline).HasColumnName("next_bar_exam_last_filing_deadline");
			entity.Property(e => e.NextBarExamLateFilingDeadline).HasColumnName("next_bar_exam_late_filing_deadline");
			entity.Property(e => e.NextBarExamTimelyFilingDeadline).HasColumnName("next_bar_exam_timely_filing_deadline");
			entity.Property(e => e.NextThemisBarReviewEarlyEnrollmentDeadline).HasColumnName("next_themis_bar_review_early_enrollment_deadline");
			entity.Property(e => e.NextThemisBarReviewOpenDate).HasColumnName("next_themis_bar_review_open_date");
			entity.Property(e => e.NextThemisBarReviewRecommendedStartDate).HasColumnName("next_themis_bar_review_recommended_start_date");
			entity.Property(e => e.Nickname)
				.HasMaxLength(255)
				.HasColumnName("nickname");
			entity.Property(e => e.OfficialStateBarExamFebruaryResultsUrl)
				.HasMaxLength(255)
				.HasColumnName("official_state_bar_exam_february_results_url");
			entity.Property(e => e.OfficialStateBarExamInfoUrl)
				.HasMaxLength(255)
				.HasColumnName("official_state_bar_exam_info_url");
			entity.Property(e => e.OfficialStateBarExamJulyResultsUrl)
				.HasMaxLength(255)
				.HasColumnName("official_state_bar_exam_july_results_url");
			entity.Property(e => e.OfficialStateBarExamPricingUrl)
				.HasMaxLength(255)
				.HasColumnName("official_state_bar_exam_pricing_url");
			entity.Property(e => e.OfficialStateBarExamResultsUrls)
				.HasMaxLength(255)
				.HasColumnName("official_state_bar_exam_results_urls");
			entity.Property(e => e.OurRecentFirstTimePassRate)
				.HasColumnType("int(11)")
				.HasColumnName("our_recent_first_time_pass_rate");
			entity.Property(e => e.OutlineClassificationId)
				.HasColumnType("int(11)")
				.HasColumnName("outline_classification_id");
			entity.Property(e => e.Path)
				.HasMaxLength(50)
				.HasColumnName("path");
			entity.Property(e => e.PrimaryBarExamTestimonialId)
				.HasColumnType("int(11)")
				.HasColumnName("primary_bar_exam_testimonial_id");
			entity.Property(e => e.PrimaryMpreTestimonialId)
				.HasColumnType("int(11)")
				.HasColumnName("primary_mpre_testimonial_id");
			entity.Property(e => e.PublicRecentFirstTimePassRate)
				.HasColumnType("int(11)")
				.HasColumnName("public_recent_first_time_pass_rate");
			entity.Property(e => e.SecondBarExamLocalComponentDescriptionMarkdownBlurb)
				.HasColumnType("text")
				.HasColumnName("second_bar_exam_local_component_description_markdown_blurb");
			entity.Property(e => e.SecondBarExamLocalComponentName)
				.HasMaxLength(255)
				.HasColumnName("second_bar_exam_local_component_name");
			entity.Property(e => e.SecondBarExamLocalComponentSubtitle)
				.HasMaxLength(255)
				.HasColumnName("second_bar_exam_local_component_subtitle");
			entity.Property(e => e.SeoValue)
				.HasColumnType("int(11)")
				.HasColumnName("seo_value");
			entity.Property(e => e.TaxRate)
				.HasPrecision(10, 5)
				.HasColumnName("tax_rate");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
		});

		modelBuilder.Entity<UsStateArticleLink>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("us_state_article_links")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.UsStateCode, e.Purpose }, "index_us_state_article_links_on_us_state_code_and_purpose");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.ArticlePublishedAt)
				.HasColumnType("datetime")
				.HasColumnName("article_published_at");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Purpose).HasColumnName("purpose");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.Url)
				.HasMaxLength(255)
				.HasColumnName("url");
			entity.Property(e => e.UsStateCode)
				.HasMaxLength(2)
				.HasColumnName("us_state_code");
		});

		modelBuilder.Entity<UsStateBarExamLocation>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("us_state_bar_exam_locations")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.UsStateCode, "index_us_state_bar_exam_locations_on_us_state_code");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Address)
				.HasMaxLength(255)
				.HasColumnName("address");
			entity.Property(e => e.City)
				.HasMaxLength(255)
				.HasColumnName("city");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.Url)
				.HasMaxLength(255)
				.HasColumnName("url");
			entity.Property(e => e.UsStateCode)
				.HasMaxLength(2)
				.HasColumnName("us_state_code");
			entity.Property(e => e.Venue)
				.HasMaxLength(255)
				.HasColumnName("venue");
		});

		modelBuilder.Entity<UsStateBarExamPricing>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("us_state_bar_exam_pricings")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => e.UsStateCode, "index_us_state_bar_exam_pricings_on_us_state_code");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.FilingDeadline).HasColumnName("filing_deadline");
			entity.Property(e => e.FilingName)
				.HasMaxLength(255)
				.HasColumnName("filing_name");
			entity.Property(e => e.Pos)
				.HasColumnType("int(11)")
				.HasColumnName("pos");
			entity.Property(e => e.Price)
				.HasPrecision(10, 2)
				.HasColumnName("price");
			entity.Property(e => e.Qualification)
				.HasMaxLength(255)
				.HasColumnName("qualification");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UsStateCode)
				.HasMaxLength(2)
				.HasColumnName("us_state_code");
		});

		modelBuilder.Entity<UsStateStat>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("us_state_stats")
				.HasCharSet("utf8")
				.UseCollation("utf8_unicode_ci");

			entity.HasIndex(e => new { e.UsStateCode, e.Year }, "index_us_state_stats_on_us_state_code_and_year");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.NumFirstTimersPassingTheBar)
				.HasColumnType("int(11)")
				.HasColumnName("num_first_timers_passing_the_bar");
			entity.Property(e => e.NumFirstTimersTakingTheBar)
				.HasColumnType("int(11)")
				.HasColumnName("num_first_timers_taking_the_bar");
			entity.Property(e => e.NumPassingTheBar)
				.HasColumnType("int(11)")
				.HasColumnName("num_passing_the_bar");
			entity.Property(e => e.NumTakingTheBar)
				.HasColumnType("int(11)")
				.HasColumnName("num_taking_the_bar");
			entity.Property(e => e.OurPublishedFirstTimePassRate)
				.HasColumnType("int(11)")
				.HasColumnName("our_published_first_time_pass_rate");
			entity.Property(e => e.PublicPublishedFirstTimePassRate)
				.HasColumnType("int(11)")
				.HasColumnName("public_published_first_time_pass_rate");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.HasColumnName("updated_at");
			entity.Property(e => e.UsStateCode)
				.HasMaxLength(2)
				.HasColumnName("us_state_code");
			entity.Property(e => e.Year)
				.HasColumnType("int(11)")
				.HasColumnName("year");
		});

		modelBuilder.Entity<User>(entity =>
		{
			entity.HasKey(e => e.IdUser).HasName("PRIMARY");

			entity.ToTable("users");

			entity.HasIndex(e => e.CreatorUserId, "creator_user_id");

			entity.HasIndex(e => e.EmailNormalized, "index_users_on_email_normalized");

			entity.HasIndex(e => e.ResetPasswordToken, "index_users_on_reset_password_token");

			entity.HasIndex(e => e.Username, "username").IsUnique();

			entity.HasIndex(e => e.Active, "users_active");

			entity.HasIndex(e => e.Email, "users_email");

			entity.HasIndex(e => e.IdRole, "users_id_role_index");

			entity.HasIndex(e => e.LastName, "users_last_name");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AlternateEmail)
				.HasMaxLength(30)
				.HasColumnName("alternate_email");
			entity.Property(e => e.AlternatePhone)
				.HasMaxLength(30)
				.HasColumnName("alternate_phone");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.CreatorUserId)
				.HasColumnType("int(11)")
				.HasColumnName("creator_user_id");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("email");
			entity.Property(e => e.EmailNormalized)
				.HasMaxLength(100)
				.HasColumnName("email_normalized");
			entity.Property(e => e.EncryptedPassword)
				.HasMaxLength(60)
				.HasColumnName("encrypted_password");
			entity.Property(e => e.FirstName)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("first_name");
			entity.Property(e => e.HomePhone)
				.HasMaxLength(30)
				.HasColumnName("home_phone");
			entity.Property(e => e.IdRole)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_role");
			entity.Property(e => e.IdTimeZone)
				.HasColumnType("int(11)")
				.HasColumnName("id_time_zone");
			entity.Property(e => e.LastName)
				.IsRequired()
				.HasMaxLength(254)
				.HasColumnName("last_name");
			entity.Property(e => e.LeadType)
				.HasMaxLength(15)
				.HasColumnName("lead_type");
			entity.Property(e => e.MemberId)
				.HasColumnType("int(11)")
				.HasColumnName("member_id");
			entity.Property(e => e.MobilePhone)
				.HasMaxLength(30)
				.HasColumnName("mobile_phone");
			entity.Property(e => e.Password)
				.HasMaxLength(255)
				.HasColumnName("password");
			entity.Property(e => e.ResetPasswordSentAt)
				.HasColumnType("datetime")
				.HasColumnName("reset_password_sent_at");
			entity.Property(e => e.ResetPasswordToken).HasColumnName("reset_password_token");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.Username)
				.IsRequired()
				.HasColumnName("username");
			entity.Property(e => e.UworldHashedPassword)
				.HasMaxLength(255)
				.HasColumnName("uworld_hashed_password");
			entity.Property(e => e.UworldUserId)
				.HasColumnType("bigint(20)")
				.HasColumnName("uworld_user_id");
		});

		modelBuilder.Entity<UserDisengagementEmail>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("user_disengagement_emails", tb => tb.HasComment("This table keeps track of disengagement emails sent to user"));

			entity.HasIndex(e => e.IdReg, "fk_id_reg_ude_id_reg_ce");

			entity.HasIndex(e => e.IdCourse, "index_id_course_ude");

			entity.HasIndex(e => e.Id, "index_id_ude_unique").IsUnique();

			entity.HasIndex(e => e.IdUser, "index_id_user_ude");

			entity.Property(e => e.Id)
				.HasComment("Primary key")
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.CreatedAt)
				.HasDefaultValueSql("'0000-00-00 00:00:00'")
				.HasComment("created at")
				.HasColumnType("timestamp")
				.HasColumnName("created_at");
			entity.Property(e => e.Email)
				.IsRequired()
				.HasMaxLength(254)
				.HasComment("User email")
				.HasColumnName("email");
			entity.Property(e => e.EmailContent)
				.HasComment("email content sent")
				.HasColumnType("text")
				.HasColumnName("email_content");
			entity.Property(e => e.IdCourse)
				.HasComment("Course Id")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdReg)
				.HasComment("Course enrollment id")
				.HasColumnType("int(11)")
				.HasColumnName("id_reg");
			entity.Property(e => e.IdUser)
				.HasComment("User id")
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.SentAt)
				.ValueGeneratedOnAddOrUpdate()
				.HasDefaultValueSql("CURRENT_TIMESTAMP")
				.HasComment("sent at date")
				.HasColumnType("timestamp")
				.HasColumnName("sent_at");
			entity.Property(e => e.Status)
				.HasComment("status of the email sent")
				.HasColumnType("int(11)")
				.HasColumnName("status");
			entity.Property(e => e.UpdatedAt)
				.HasColumnType("timestamp")
				.HasColumnName("updated_at");

			entity.HasOne(d => d.IdCourseNavigation).WithMany(p => p.UserDisengagementEmails)
				.HasForeignKey(d => d.IdCourse)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_course_ude_id_course_courses");

			entity.HasOne(d => d.IdRegNavigation).WithMany(p => p.UserDisengagementEmails)
				.HasForeignKey(d => d.IdReg)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_reg_ude_id_reg_ce");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserDisengagementEmails)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_id_user_ude_id_user_users");
		});

		modelBuilder.Entity<UserSetting>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.Attribute })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("user_settings");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Attribute)
				.HasMaxLength(16)
				.HasColumnName("attribute");
			entity.Property(e => e.Value)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("value");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserSettings)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_user_settings_id_user");
		});

		modelBuilder.Entity<UserUpdateScheduleEvent>(entity =>
		{
			entity.HasKey(e => e.IdUpdateScheduleEvent).HasName("PRIMARY");

			entity
				.ToTable("user_update_schedule_events")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdCourse, "course_events");

			entity.HasIndex(e => new { e.IdUser, e.IdCourse }, "user_course_events");

			entity.Property(e => e.IdUpdateScheduleEvent)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_update_schedule_event");
			entity.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.HasColumnName("created_at");
			entity.Property(e => e.IdCourse)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_course");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.StatusCode)
				.HasMaxLength(255)
				.HasColumnName("status_code");
		});

		modelBuilder.Entity<UsersUworldAccountReset>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.Created })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity
				.ToTable("users_uworld_account_resets")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.ResetBy)
				.HasColumnType("int(11)")
				.HasColumnName("reset_by");
			entity.Property(e => e.UworldHashedPassword)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("uworld_hashed_password");
			entity.Property(e => e.UworldUserId)
				.HasColumnType("bigint(20)")
				.HasColumnName("uworld_user_id");
		});

		modelBuilder.Entity<UworldQbankStudentAttributeStatistic>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("uworld_qbank_student_attribute_statistics")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => new { e.StudentId, e.GroupId, e.ParentAttributeId, e.AttributeId }, "index_student_group_parent_attribute_stats");

			entity.Property(e => e.Id)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("id");
			entity.Property(e => e.AttributeId)
				.HasColumnType("int(11)")
				.HasColumnName("attribute_id");
			entity.Property(e => e.AttributeName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("attribute_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.ConvertedDateOfExpiry)
				.HasColumnType("datetime")
				.HasColumnName("converted_date_of_expiry");
			entity.Property(e => e.CourseName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("course_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.DateOfExpiry)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("date_of_expiry")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.GroupId)
				.HasColumnType("int(11)")
				.HasColumnName("group_id");
			entity.Property(e => e.GroupName)
				.HasMaxLength(255)
				.HasComment(" deprecated column ")
				.HasColumnName("group_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.ParentAttributeId)
				.HasColumnType("int(11)")
				.HasColumnName("parent_attribute_id");
			entity.Property(e => e.ParentAttributeName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("parent_attribute_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.SchoolName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("school_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.StudentEmail)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("student_email")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.StudentId)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("student_id");
			entity.Property(e => e.StudentName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("student_name");
			entity.Property(e => e.TotalQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions");
			entity.Property(e => e.TotalQuestionsCorrect)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_correct");
			entity.Property(e => e.TotalQuestionsIncorrect)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_incorrect");
			entity.Property(e => e.TotalQuestionsOmitted)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_omitted");
			entity.Property(e => e.UniqueUsedQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("unique_used_questions");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<UworldQbankStudentOverallStatistic>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity
				.ToTable("uworld_qbank_student_overall_statistics")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => new { e.StudentId, e.GroupId }, "index_student_group_overall_stats");

			entity.Property(e => e.Id)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("id");
			entity.Property(e => e.ChanceOfPassing)
				.HasMaxLength(255)
				.HasComment(" deprecated column ")
				.HasColumnName("chance_of_passing")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.ConvertedDateOfExpiry)
				.HasColumnType("datetime")
				.HasColumnName("converted_date_of_expiry");
			entity.Property(e => e.CourseName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("course_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.DateOfExpiry)
				.IsRequired()
				.HasMaxLength(10)
				.HasColumnName("date_of_expiry")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.Duration)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("duration")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.GroupId)
				.HasColumnType("int(11)")
				.HasColumnName("group_id");
			entity.Property(e => e.GroupName)
				.HasMaxLength(255)
				.HasComment(" deprecated column ")
				.HasColumnName("group_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.SchoolName)
				.IsRequired()
				.HasMaxLength(255)
				.HasDefaultValueSql("''")
				.HasColumnName("school_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.StudentEmail)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("student_email")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.StudentId)
				.HasColumnType("int(11) unsigned")
				.HasColumnName("student_id");
			entity.Property(e => e.StudentName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("student_name")
				.UseCollation("latin1_swedish_ci")
				.HasCharSet("latin1");
			entity.Property(e => e.TotalQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions");
			entity.Property(e => e.TotalQuestionsCorrect)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_correct");
			entity.Property(e => e.TotalQuestionsIncorrect)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_incorrect");
			entity.Property(e => e.TotalQuestionsOmitted)
				.HasColumnType("int(11)")
				.HasColumnName("total_questions_omitted");
			entity.Property(e => e.UniqueUsedQuestions)
				.HasColumnType("int(11)")
				.HasColumnName("unique_used_questions");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<Vendor>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PRIMARY");

			entity.ToTable("vendors");

			entity.Property(e => e.Id)
				.HasColumnType("int(11)")
				.HasColumnName("id");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.ContactEmail)
				.HasMaxLength(255)
				.HasColumnName("contact_email");
			entity.Property(e => e.ContactName)
				.HasMaxLength(255)
				.HasColumnName("contact_name");
			entity.Property(e => e.ContactPhone)
				.HasMaxLength(255)
				.HasColumnName("contact_phone");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdLawFirm)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_firm");
			entity.Property(e => e.IdLawSchool)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_law_school");
			entity.Property(e => e.Name)
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.VendorType)
				.HasColumnType("enum('firm','school','generic')")
				.HasColumnName("vendor_type");
		});

		modelBuilder.Entity<Video>(entity =>
		{
			entity.HasKey(e => e.IdVideo).HasName("PRIMARY");

			entity.ToTable("videos");

			entity.HasIndex(e => e.IdVideoSet, "fk_video_video_sets1");

			entity.HasIndex(e => e.Active, "videos_active");

			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.AssessmentQuestionsApprovalCriteria)
				.HasColumnType("tinyint(3)")
				.HasColumnName("assessment_questions_approval_criteria");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.HandoutFilePath)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("handout_file_path");
			entity.Property(e => e.IdVideoSet)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video_set");
			entity.Property(e => e.LecturerInformation)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("lecturer_information");
			entity.Property(e => e.LecturerName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("lecturer_name");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Position)
				.HasColumnType("int(11)")
				.HasColumnName("position");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdVideoSetNavigation).WithMany(p => p.Videos)
				.HasForeignKey(d => d.IdVideoSet)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_video_video_sets1");
		});

		modelBuilder.Entity<VideoLink>(entity =>
		{
			entity.HasKey(e => e.IdVideoLinks).HasName("PRIMARY");

			entity.ToTable("video_links");

			entity.HasIndex(e => e.IdVideo, "fk_video_links_videos1");

			entity.HasIndex(e => e.Active, "video_links_active");

			entity.Property(e => e.IdVideoLinks)
				.HasColumnType("int(11)")
				.HasColumnName("id_video_links");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.IdVideo)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_video");
			entity.Property(e => e.SubtitleUrl)
				.HasMaxLength(255)
				.HasColumnName("subtitle_url");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.VideoType)
				.IsRequired()
				.HasColumnType("enum('hi_res_stream','hi_res_no_stream','low_res_no_stream')")
				.HasColumnName("video_type");
			entity.Property(e => e.VideoUrl)
				.HasColumnType("text")
				.HasColumnName("video_url");

			entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.VideoLinks)
				.HasForeignKey(d => d.IdVideo)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_video_links_videos1");
		});

		modelBuilder.Entity<VideoSet>(entity =>
		{
			entity.HasKey(e => e.IdVideoSet).HasName("PRIMARY");

			entity.ToTable("video_sets");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_video_sets_subject_outlines1");

			entity.HasIndex(e => e.Name, "name");

			entity.HasIndex(e => e.Active, "video_sets_active");

			entity.Property(e => e.IdVideoSet)
				.HasColumnType("bigint(11)")
				.HasColumnName("id_video_set");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(11)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasColumnName("name");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<WrittenQuestion>(entity =>
		{
			entity.HasKey(e => e.IdWrittenQuestion).HasName("PRIMARY");

			entity.ToTable("written_questions");

			entity.HasIndex(e => e.WrittenQuestionType, "wq_type");

			entity.HasIndex(e => e.Active, "written_questions_active");

			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.CharactersLimit)
				.HasColumnType("int(11)")
				.HasColumnName("characters_limit");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.Graded).HasColumnName("graded");
			entity.Property(e => e.HasEval).HasColumnName("has_eval");
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnName("name");
			entity.Property(e => e.Notes)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("notes");
			entity.Property(e => e.OriginPosition)
				.HasColumnType("smallint(6)")
				.HasColumnName("origin_position");
			entity.Property(e => e.OriginSession)
				.HasColumnType("tinyint(4)")
				.HasColumnName("origin_session");
			entity.Property(e => e.OriginYear)
				.HasColumnType("smallint(6)")
				.HasColumnName("origin_year");
			entity.Property(e => e.QuestionModelAnswer)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_model_answer");
			entity.Property(e => e.QuestionText)
				.IsRequired()
				.HasColumnType("text")
				.HasColumnName("question_text");
			entity.Property(e => e.TimeLimit)
				.HasComment("time in minutes")
				.HasColumnType("int(11)")
				.HasColumnName("time_limit");
			entity.Property(e => e.Updated)
				.HasComment("\n")
				.HasColumnType("datetime")
				.HasColumnName("updated");
			entity.Property(e => e.WrittenQuestionType)
				.IsRequired()
				.HasColumnType("enum('essay','short_answer')")
				.HasColumnName("written_question_type");
		});

		modelBuilder.Entity<WrittenQuestionsChapter>(entity =>
		{
			entity.HasKey(e => new { e.IdWrittenQuestion, e.IdChapter })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("written_questions_chapters");

			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdChapter)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_chapter");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");
		});

		modelBuilder.Entity<WrittenQuestionsLearnersBenchmark>(entity =>
		{
			entity.HasKey(e => new { e.IdUser, e.IdTask, e.IdWrittenQuestion, e.IdEssayBenchmark })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

			entity
				.ToTable("written_questions_learners_benchmarks")
				.HasCharSet("utf8")
				.UseCollation("utf8_general_ci");

			entity.HasIndex(e => e.IdEssayBenchmark, "id_essay_benchmark");

			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdEssayBenchmark)
				.HasColumnType("int(11)")
				.HasColumnName("id_essay_benchmark");
			entity.Property(e => e.Result).HasColumnName("result");

			entity.HasOne(d => d.IdEssayBenchmarkNavigation).WithMany(p => p.WrittenQuestionsLearnersBenchmarks)
				.HasForeignKey(d => d.IdEssayBenchmark)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("written_questions_learners_benchmarks_ibfk_1");
		});

		modelBuilder.Entity<WrittenQuestionsSubject>(entity =>
		{
			entity.HasKey(e => new { e.IdWrittenQuestion, e.IdSubjectOutline })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

			entity.ToTable("written_questions_subjects");

			entity.HasIndex(e => e.IdSubjectOutline, "fk_written_questions_subjects_subject_outlines1");

			entity.HasIndex(e => e.IdWrittenQuestion, "id_wq");

			entity.HasIndex(e => e.Active, "written_questions_subjects_active");

			entity.HasIndex(e => e.IsPrimary, "written_questions_subjects_is_primary_index");

			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdSubjectOutline)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_subject_outline");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.Enabled).HasColumnName("enabled");
			entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdSubjectOutlineNavigation).WithMany(p => p.WrittenQuestionsSubjects)
				.HasForeignKey(d => d.IdSubjectOutline)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_written_questions_subjects_subject_outlines1");

			entity.HasOne(d => d.IdWrittenQuestionNavigation).WithMany(p => p.WrittenQuestionsSubjects)
				.HasForeignKey(d => d.IdWrittenQuestion)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_written_questions_subjects_written_questions1");
		});

		modelBuilder.Entity<WrittenQuestionsTasksLearner>(entity =>
		{
			entity.HasKey(e => new { e.IdWrittenQuestion, e.IdUser, e.IdTask })
				.HasName("PRIMARY")
				.HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

			entity.ToTable("written_questions_tasks_learners");

			entity.HasIndex(e => e.IdUser, "fk_essay_task_questions_learners1");

			entity.HasIndex(e => e.IdWrittenQuestion, "id_essay_question");

			entity.HasIndex(e => e.IdTask, "id_task");

			entity.HasIndex(e => e.Active, "written_questions_tasks_learners_active");

			entity.Property(e => e.IdWrittenQuestion)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_written_question");
			entity.Property(e => e.IdUser)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_user");
			entity.Property(e => e.IdTask)
				.HasColumnType("bigint(20)")
				.HasColumnName("id_task");
			entity.Property(e => e.Active).HasColumnName("active");
			entity.Property(e => e.Answer)
				.IsRequired()
				.HasColumnName("answer");
			entity.Property(e => e.Created)
				.HasColumnType("datetime")
				.HasColumnName("created");
			entity.Property(e => e.QuestionTime)
				.HasColumnType("smallint(6)")
				.HasColumnName("question_time");
			entity.Property(e => e.SubmissionDate).HasColumnName("submission_date");
			entity.Property(e => e.Updated)
				.HasColumnType("datetime")
				.HasColumnName("updated");

			entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.WrittenQuestionsTasksLearners)
				.HasForeignKey(d => d.IdUser)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_essay_task_questions_learners1");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
