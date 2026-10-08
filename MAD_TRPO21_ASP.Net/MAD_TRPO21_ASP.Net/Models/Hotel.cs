using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public decimal Rating { get; set; }

    public decimal PricePerNight { get; set; }

    public bool IsAvailable { get; set; }
}
