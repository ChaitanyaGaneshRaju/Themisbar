using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MultipleChoiceQuestion
{
    public long IdMultipleChoiceQuestion { get; set; }

    public long IdQuestion { get; set; }

    public int IdQuestionType { get; set; }

    public int? UworldQuestionId { get; set; }

    public string QuestionRationale { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public string Identifier { get; set; }

    public long? IdQuestionBatch { get; set; }

    public string Notes { get; set; }

    public virtual ICollection<CcpQuizAnswer> CcpQuizAnswers { get; } = new List<CcpQuizAnswer>();

    public virtual ICollection<CoursesMcqResult> CoursesMcqResults { get; } = new List<CoursesMcqResult>();

    public virtual ICollection<ExamAnswerStrikethrough> ExamAnswerStrikethroughs { get; } = new List<ExamAnswerStrikethrough>();

    public virtual Question IdQuestionNavigation { get; set; }

    public virtual ICollection<McqFeedback> McqFeedbacks { get; } = new List<McqFeedback>();

    public virtual ICollection<MilestoneExamsMultipleChoiceQuestion> MilestoneExamsMultipleChoiceQuestions { get; } = new List<MilestoneExamsMultipleChoiceQuestion>();

    public virtual ICollection<MultipleChoiceSetsMultipleChoiceQuestion> MultipleChoiceSetsMultipleChoiceQuestions { get; } = new List<MultipleChoiceSetsMultipleChoiceQuestion>();
}
