using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Address
{
    public long IdAddress { get; set; }

    public long IdUser { get; set; }

    public string Type { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public long IdState { get; set; }

    public long IdCountry { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public sbyte Active { get; set; }

    public virtual User IdUserNavigation { get; set; }
}
