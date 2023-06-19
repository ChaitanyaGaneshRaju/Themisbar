using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ShippingBatchItem
{
    public long? IdShippingBatchItem { get; set; }

    public long? IdBatch { get; set; }

    public long IdReg { get; set; }

    public long? IdUser { get; set; }

    public int? IdCourse { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public long? IdState { get; set; }

    public string ZipCode { get; set; }

    public long? IdCountry { get; set; }

    public string Phone { get; set; }

    public long IdAddonType { get; set; }
}
