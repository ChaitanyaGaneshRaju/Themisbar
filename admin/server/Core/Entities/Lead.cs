using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Lead
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public long? IdUser { get; set; }

    public int? IdLawSchool { get; set; }

    public DateOnly? GraduationDate { get; set; }

    public int? IdStudentType { get; set; }

    public int? IdProgramType { get; set; }

    public int? IdAssignedRep { get; set; }

    public bool? IsCompetitorRep { get; set; }

    public string EmploymentInfo { get; set; }

    public int? LeadLevel { get; set; }

    public int? IdCourseChoice { get; set; }

    public string Notes { get; set; }

    public bool OnlyBarSupport { get; set; }

    public DateOnly? ContactDate { get; set; }

    public string ContactMethod { get; set; }

    /// <summary>
    /// Organizations involved by the leads
    /// </summary>
    public string StudentOrganizations { get; set; }

    public bool MpreTaken { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }
}
