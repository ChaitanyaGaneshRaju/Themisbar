using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UsState
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public string Path { get; set; }

    public int? OutlineClassificationId { get; set; }

    public int? OurRecentFirstTimePassRate { get; set; }

    public int? PublicRecentFirstTimePassRate { get; set; }

    public int? BarDifficultyRank { get; set; }

    public int? SeoValue { get; set; }

    public string Nickname { get; set; }

    public string BarExamMetaKeywords { get; set; }

    public bool? HasBarReviewOffering { get; set; }

    public string MpreMetaKeywords { get; set; }

    public int? MpreMinScore { get; set; }

    public bool? HasMpreReviewOffering { get; set; }

    public bool? IsUbe { get; set; }

    public int? PrimaryMpreTestimonialId { get; set; }

    public string BarExamTestSubjects { get; set; }

    public string BarExamLocalComponentName { get; set; }

    public string BarExamLocalComponentSubtitle { get; set; }

    public string BarExamLocalComponentDescriptionMarkdownBlurb { get; set; }

    public string SecondBarExamLocalComponentName { get; set; }

    public string SecondBarExamLocalComponentSubtitle { get; set; }

    public string SecondBarExamLocalComponentDescriptionMarkdownBlurb { get; set; }

    public string CourseOverviewCalendarUrl { get; set; }

    public DateOnly? CourseOverviewCalendarDate { get; set; }

    public string OfficialStateBarExamInfoUrl { get; set; }

    public string OfficialStateBarExamPricingUrl { get; set; }

    public string OfficialStateBarExamResultsUrls { get; set; }

    public short? BarExamFebruaryResultsYear { get; set; }

    public string OfficialStateBarExamFebruaryResultsUrl { get; set; }

    public string BarExamFebruaryResultsMardownBlurb { get; set; }

    public short? BarExamJulyResultsYear { get; set; }

    public string OfficialStateBarExamJulyResultsUrl { get; set; }

    public string BarExamJulyResultsMardownBlurb { get; set; }

    public bool? HasMbeComponent { get; set; }

    public string MbeComponentSubtitle { get; set; }

    public bool? HasMptComponent { get; set; }

    public string MptComponentSubtitle { get; set; }

    public bool? HasMeeComponent { get; set; }

    public string MeeComponentSubtitle { get; set; }

    public string MeeComponentMarkdownBlurb { get; set; }

    public string BarExamLocalComponentFormatMarkdownBlurb { get; set; }

    public string BarAssociationInitials { get; set; }

    public int? PrimaryBarExamTestimonialId { get; set; }

    public DateOnly? NextBarExamDate { get; set; }

    public DateOnly? NextBarExamTimelyFilingDeadline { get; set; }

    public DateOnly? NextBarExamLateFilingDeadline { get; set; }

    public DateOnly? NextBarExamLastFilingDeadline { get; set; }

    public DateOnly? NextThemisBarReviewOpenDate { get; set; }

    public DateOnly? NextThemisBarReviewRecommendedStartDate { get; set; }

    public DateOnly? NextThemisBarReviewEarlyEnrollmentDeadline { get; set; }

    public string BannerNotice { get; set; }

    public decimal? TaxRate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
