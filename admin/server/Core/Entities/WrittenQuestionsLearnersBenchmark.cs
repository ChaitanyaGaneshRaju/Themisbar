using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class WrittenQuestionsLearnersBenchmark
{
    public long IdUser { get; set; }

    public long IdTask { get; set; }

    public long IdWrittenQuestion { get; set; }

    public int IdEssayBenchmark { get; set; }

    public bool? Result { get; set; }

    public virtual EssayBenchmark IdEssayBenchmarkNavigation { get; set; }
}
