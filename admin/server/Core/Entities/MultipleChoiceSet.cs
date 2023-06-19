using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class MultipleChoiceSet
{
    public long IdMultipleChoiceSet { get; set; }

    public string Name { get; set; }

    public string SetType { get; set; }

    public byte QuestionsQuantity { get; set; }

    public long IdOutlineClassification { get; set; }

    public bool Enabled { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CcpQuizAttempt> CcpQuizAttempts { get; } = new List<CcpQuizAttempt>();

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual ICollection<MultipleChoiceSetsMultipleChoiceQuestion> MultipleChoiceSetsMultipleChoiceQuestions { get; } = new List<MultipleChoiceSetsMultipleChoiceQuestion>();
}
