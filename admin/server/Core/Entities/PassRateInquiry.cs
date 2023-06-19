using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PassRateInquiry
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string Email { get; set; }

    public int? IdLawSchool { get; set; }

    public string Message { get; set; }

    public string EmailedTo { get; set; }

    public DateTime Created { get; set; }
}
