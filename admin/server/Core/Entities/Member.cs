using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Member
{
    public int Id { get; set; }

    public string FullNameSpecified { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string EmailSpecified { get; set; }

    public string EmailNormalized { get; set; }

    public string PhoneSpecified { get; set; }

    public string PhoneNormalized { get; set; }

    public string LawSchoolName { get; set; }

    public int? LawSchoolId { get; set; }

    public DateOnly? LawSchoolStartDate { get; set; }

    public DateOnly? GraduationDate { get; set; }

    public bool? HasTakenBarExam { get; set; }

    public bool? HasPassedBarExam { get; set; }

    public DateOnly? LastBarExamDate { get; set; }

    public DateOnly? NextBarExamDate { get; set; }

    public string NextBarExamState { get; set; }

    public bool? HasTakenMpre { get; set; }

    public bool? HasPassedMpre { get; set; }

    public DateOnly? LastMpreDate { get; set; }

    public DateOnly? NextMpreDate { get; set; }

    public bool? InterestedInGeneralInfo { get; set; }

    public bool? InterestedInBarReview { get; set; }

    public bool? InterestedInBarReviewReminders { get; set; }

    public bool? InterestedInMpreReview { get; set; }

    public bool? InterestedInMpreReviewReminders { get; set; }

    public bool? InterestedInLse { get; set; }

    public bool? InterestedInLseFirstYear { get; set; }

    public bool? InterestedInLseUpperLevel { get; set; }

    public DateOnly? LastBarReviewDate { get; set; }

    public DateOnly? LastMpreReviewDate { get; set; }

    public DateOnly? LastLseFirstYearDate { get; set; }

    public DateOnly? LastLseUpperLevelDate { get; set; }

    public bool? HasOptedOutOfEmailMarketing { get; set; }

    public string Uvt { get; set; }

    public string UtmSource { get; set; }

    public string UtmMedium { get; set; }

    public string UtmCampaign { get; set; }

    public string UtmTerm { get; set; }

    public string UtmContent { get; set; }

    public string RemoteIpAddr { get; set; }

    public string GeoCity { get; set; }

    public string GeoState { get; set; }

    public string GeoCountry { get; set; }

    public string XForwardedForIpAddr { get; set; }

    public string UserAgent { get; set; }

    public string HttpReferrer { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
