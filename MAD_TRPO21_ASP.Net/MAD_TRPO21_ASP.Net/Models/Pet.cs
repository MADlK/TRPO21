using System;
using System.Collections.Generic;

namespace MAD_TRPO21_ASP.Net.Models;

public partial class Pet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Species { get; set; } = null!;

    public int Age { get; set; }

    public decimal Weight { get; set; }

    public bool IsAdopted { get; set; }
}
