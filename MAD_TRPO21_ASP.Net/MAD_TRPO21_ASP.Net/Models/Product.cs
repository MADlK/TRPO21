using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Category { get; set; } = null!;

    public bool IsAvailable { get; set; }
}
