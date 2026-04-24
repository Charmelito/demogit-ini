using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpErrorcuest
{
    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public decimal NumRespuesta { get; set; }
}
