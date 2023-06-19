using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LawFirm
{
    public long IdLawFirm { get; set; }

    public string Name { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool? Enabled { get; set; }

    public long IdState { get; set; }

    public string City { get; set; }

    public bool? Active { get; set; }

    public string BillingFirstName { get; set; }

    public string BillingLastName { get; set; }

    public string BillingJobTitle { get; set; }

    public string BillingPhone { get; set; }

    public string BillingEmail { get; set; }

    public string InvoicePreferences { get; set; }

    public bool? HasTechPackage { get; set; }

    public bool? HasShippingFee { get; set; }

    public string Notes { get; set; }

    public string RecruiterFirstName { get; set; }

    public string RecruiterLastName { get; set; }

    public string RecruiterJobTitle { get; set; }

    public string RecruiterPhone { get; set; }

    public string RecruiterEmail { get; set; }

    public virtual State IdStateNavigation { get; set; }
}
