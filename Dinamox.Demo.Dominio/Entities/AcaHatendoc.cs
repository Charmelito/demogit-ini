using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHatendoc
{
    public decimal NumAtencion { get; set; }

    public decimal TipDocumento { get; set; }

    public decimal IndTipo { get; set; }

    public decimal CodModoenvio { get; set; }

    public DateTime FecHistorico { get; set; }

    public virtual AcaHatencion NumAtencionNavigation { get; set; } = null!;
}
