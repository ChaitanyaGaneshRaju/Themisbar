using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ConDetrimental
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string BarExamState { get; set; }

    public string ExamDate { get; set; }

    public string LawSchoolState { get; set; }

    public long? IdLawSchool { get; set; }

    public string GraduationMonth { get; set; }

    public string GraduationYear { get; set; }

    public bool? AccessFreeLseMaterials { get; set; }

    public string EnrollInLseMaterials { get; set; }

    public bool? AccessFreeMpre { get; set; }

    public string MpreDate { get; set; }

    public DateTime? Created { get; set; }
}
