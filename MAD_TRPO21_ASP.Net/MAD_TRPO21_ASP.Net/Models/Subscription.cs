using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int DurationDays { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }
}
