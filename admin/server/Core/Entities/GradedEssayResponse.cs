using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class GradedEssayResponse
{
    public long IdWrittenQuestion { get; set; }

    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public string Response { get; set; }

    public DateOnly GradingDate { get; set; }

    public int? StructureScore { get; set; }

    public int? LegalKnowledgeScore { get; set; }

    public int? AnalysisScore { get; set; }

    public int? OverallScore { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public bool Submitted { get; set; }

    public long? IdAdviser { get; set; }

    public string ResponseType { get; set; }

    public string Reason { get; set; }
}
