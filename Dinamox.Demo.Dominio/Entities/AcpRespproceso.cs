using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpRespproceso
{
    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public decimal NumRespuesta { get; set; }

    public decimal NumOrden { get; set; }

    public decimal CodProcsac { get; set; }

    public virtual AcpRespuestum AcpRespuestum { get; set; } = null!;

    public virtual AcpProceso CodProcsacNavigation { get; set; } = null!;
}
