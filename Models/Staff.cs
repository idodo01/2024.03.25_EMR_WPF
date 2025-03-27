using System;
using System.Collections.Generic;

namespace EMR.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string? Img { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }
}
