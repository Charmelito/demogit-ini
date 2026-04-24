using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCentroAc
{
    public decimal CodCentroAc { get; set; }

    public string DesCentroAc { get; set; } = null!;

    public string DirCentroAc { get; set; } = null!;
}
