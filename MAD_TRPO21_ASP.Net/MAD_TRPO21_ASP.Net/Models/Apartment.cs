using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Apartment
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public int Rooms { get; set; }

    public decimal Area { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}
