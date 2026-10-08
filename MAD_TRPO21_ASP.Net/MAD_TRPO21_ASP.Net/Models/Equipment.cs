using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string InventoryNumber { get; set; } = null!;

    public decimal Price { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public bool IsOperational { get; set; }
}
