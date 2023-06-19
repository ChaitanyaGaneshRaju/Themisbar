using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class QuestionBatch
{
    public int IdQuestionBatch { get; set; }

    public string Name { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }
}
