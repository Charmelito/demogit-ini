using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHatendetalle
{
    public decimal NumAtencion { get; set; }

    public decimal NumOrden { get; set; }

    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public decimal NumRespuesta { get; set; }

    public DateTime FecHistorico { get; set; }

    public decimal? NumIncidencia { get; set; }

    public virtual AcaHatencion NumAtencionNavigation { get; set; } = null!;
}
