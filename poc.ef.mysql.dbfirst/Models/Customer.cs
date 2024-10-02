﻿namespace poc.ef.mysql.dbfirst.Entities;

public partial class Customer
{
    public int CustomerNumber { get; set; }

    public string CustomerName { get; set; } = null!;

    public string ContactLastName { get; set; } = null!;

    public string ContactFirstName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string Country { get; set; } = null!;

    public int? SalesRepEmployeeNumber { get; set; }

    public decimal? CreditLimit { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Employee? SalesRepEmployeeNumberNavigation { get; set; }
}
