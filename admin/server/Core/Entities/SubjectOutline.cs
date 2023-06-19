using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SubjectOutline
{
    public long IdSubjectOutline { get; set; }

    public string Name { get; set; }

    public long IdOutlineClassification { get; set; }

    public string Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AdminFlashcard> AdminFlashcards { get; } = new List<AdminFlashcard>();

    public virtual ICollection<AttorneySubjectOutline> AttorneySubjectOutlines { get; } = new List<AttorneySubjectOutline>();

    public virtual ICollection<Chapter> Chapters { get; } = new List<Chapter>();

    public virtual ICollection<DrillQuestion> DrillQuestions { get; } = new List<DrillQuestion>();

    public virtual ICollection<Flashcard> Flashcards { get; } = new List<Flashcard>();

    public virtual OutlinesClassification IdOutlineClassificationNavigation { get; set; }

    public virtual ICollection<TasksIntermittentQuize> TasksIntermittentQuizes { get; } = new List<TasksIntermittentQuize>();

    public virtual ICollection<TasksMultipleChoiceSubject> TasksMultipleChoiceSubjects { get; } = new List<TasksMultipleChoiceSubject>();

    public virtual ICollection<WrittenQuestionsSubject> WrittenQuestionsSubjects { get; } = new List<WrittenQuestionsSubject>();
}
