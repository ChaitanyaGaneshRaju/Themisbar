using System;
using System.Collections.Generic;

namespace Core.Entities;

/// <summary>
/// notes and highlights from essays, graded essays, short answer PQs and written questions will be saved here
/// </summary>
public partial class ExamUserActionsEssay
{
    public int Id { get; set; }

    public int IdWrittenQuestion { get; set; }

    public int IdUser { get; set; }

    public int IdTask { get; set; }

    public string Notes { get; set; }

    public string Highlights { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
