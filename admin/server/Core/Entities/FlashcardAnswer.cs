using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class FlashcardAnswer
{
    public int Id { get; set; }

    public int IdFlashcard { get; set; }

    public long IdUser { get; set; }

    public long IdCourse { get; set; }

    public string Type { get; set; }

    public string Status { get; set; }

    public DateTime? Created { get; set; }

    public virtual Course IdCourseNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
