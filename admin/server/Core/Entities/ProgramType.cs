using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ProgramType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Abbreviation { get; set; }

    public sbyte? Position { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public bool? Active { get; set; }
}
