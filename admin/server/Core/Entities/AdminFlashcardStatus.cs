using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AdminFlashcardStatus
{
    public long IdReg { get; set; }

    public long IdFlashcard { get; set; }

    public bool? IsCorrect { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
