using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SalesforceSendLog
{
    public uint Id { get; set; }

    public long IdUser { get; set; }

    public string Data { get; set; }

    public string Status { get; set; }

    public DateTime Created { get; set; }

    public string Message { get; set; }
}
