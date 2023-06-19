using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class GradedEssayResponseEdit
{
    public long IdGradedEssayResponseEdit { get; set; }

    public long IdWrittenQuestion { get; set; }

    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public string OrigResponse { get; set; }

    public int? OrigStructureScore { get; set; }

    public int? OrigLegalKnowledgeScore { get; set; }

    public int? OrigAnalysisScore { get; set; }

    public int? OrigOverallScore { get; set; }

    public long OrigGraderId { get; set; }

    public string Reason { get; set; }

    public long EditorId { get; set; }

    public DateTime Created { get; set; }
}
