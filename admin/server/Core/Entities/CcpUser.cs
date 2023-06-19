using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CcpUser
{
    public long Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<CcpQuizAttempt> CcpQuizAttempts { get; } = new List<CcpQuizAttempt>();
}
