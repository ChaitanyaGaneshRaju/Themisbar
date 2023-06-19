using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class EssayBenchmark
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string IdEssayBenchmarkCategory { get; set; }

    public virtual ICollection<WrittenQuestionsLearnersBenchmark> WrittenQuestionsLearnersBenchmarks { get; } = new List<WrittenQuestionsLearnersBenchmark>();
}
