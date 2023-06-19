using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ThemisToUworldMcq
{
    public int Id { get; set; }

    public long ThemisQuestionId { get; set; }

    public int? UworldQuestionId { get; set; }

    public int? ClassificationId { get; set; }

    public long? IdSection { get; set; }

    public long? IdSubject { get; set; }

    public long? IdChapter { get; set; }

    public string QuestionTitle { get; set; }

    public string QuestionStem { get; set; }

    public string QuestionRationale { get; set; }

    public long CorrectAnswerId { get; set; }

    public string AnswerChoiceList { get; set; }

    public string Media { get; set; }

    public string DefinitionList { get; set; }

    public string DateModified { get; set; }

    public bool? Published { get; set; }

    public string ChangeTypeId { get; set; }

    public bool IsProcessed { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? ProcessedAt { get; set; }

    public long ProcessedBy { get; set; }

    public int? Success { get; set; }

    public string ErrorMessage { get; set; }
}
