using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAtendetalle
{
    public int NumAtencion { get; set; }

    public decimal NumOrden { get; set; }

    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public decimal NumRespuesta { get; set; }

    public decimal? NumIncidencia { get; set; }

    public virtual AcpRespuestum AcpRespuestum { get; set; } = null!;

    public virtual AcaAtencion NumAtencionNavigation { get; set; } = null!;
}
