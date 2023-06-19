using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SalesforceVariable
{
    public uint Id { get; set; }

    public string FieldId { get; set; }

    public string Value { get; set; }

    public string Type { get; set; }
}
