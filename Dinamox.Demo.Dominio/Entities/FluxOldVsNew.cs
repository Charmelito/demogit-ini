using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FluxOldVsNew
{
    public int Id { get; set; }

    public string FluxOld { get; set; } = null!;

    public string FluxNew { get; set; } = null!;
}
