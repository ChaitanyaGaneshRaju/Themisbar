using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class BillingRequest
{
    public int Id { get; set; }

    public string BillingType { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public int? IdLawSchool { get; set; }

    public DateTime? GraduationDate { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public int? IdState { get; set; }

    public string ZipCode { get; set; }

    public int? IdCountry { get; set; }

    public int? IdOutlineClassification { get; set; }

    public DateOnly? ExamDate { get; set; }

    public bool? WantsTechPackage { get; set; }

    public bool? TechPackageOptions { get; set; }

    public bool? WantsMpre { get; set; }

    public DateOnly? MpreExamDate { get; set; }

    public int? IdLawFirm { get; set; }

    public string LawFirmName { get; set; }

    public string LawFirmContactName { get; set; }

    public string LawFirmContactEmail { get; set; }

    public string LawFirmContactPhone { get; set; }

    public DateTime? Created { get; set; }
}
