using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// notes and highlights from mcq, mbe, practice tests and quiz builder will be saved here
/// </summary>
public partial class ExamUserActionsMcq
{
    public int Id { get; set; }

    public int IdMultipleChoiceQuestion { get; set; }

    public int IdUser { get; set; }

    public int? IdTask { get; set; }

    public int? IdMcqSession { get; set; }

    public string Notes { get; set; }

    public string Highlights { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
