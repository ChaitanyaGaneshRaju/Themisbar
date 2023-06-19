using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UlawEnrollment
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int? IdLawSchool { get; set; }

    public DateTime? GraduationDate { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string PostCode { get; set; }

    public int? IdCountry { get; set; }

    public int? IdOutlineClassification { get; set; }

    public DateOnly? ExamDate { get; set; }

    public string Program { get; set; }

    public bool? WantsMpre { get; set; }

    public DateOnly? MpreExamDate { get; set; }

    public DateTime? Created { get; set; }
}
