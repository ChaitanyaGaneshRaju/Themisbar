using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class DirectorsPermission
{
    public int? IdUser { get; set; }

    public bool? CanAnswerSubstantiveQuestions { get; set; }
}
