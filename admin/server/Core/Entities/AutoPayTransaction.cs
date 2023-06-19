using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class AutoPayTransaction
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public int? IdCourse { get; set; }

    public int? IdReg { get; set; }

    public int? Amount { get; set; }

    public int? BaseTransactionId { get; set; }

    public sbyte? IsAuthorized { get; set; }

    public sbyte? IsCaptured { get; set; }

    public int? CapturedIdTransaction { get; set; }

    public int? IdCcTransaction { get; set; }

    public int? IdPaymentInfo { get; set; }

    public sbyte? Success { get; set; }

    public int? ErrorCode { get; set; }

    public string ErrorMsg { get; set; }

    public string StackTrace { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
