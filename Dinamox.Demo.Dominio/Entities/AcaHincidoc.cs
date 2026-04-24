using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHincidoc
{
    public decimal NumIncidencia { get; set; }

    public decimal TipDocumento { get; set; }

    public decimal IndTipo { get; set; }

    public decimal NumOrden { get; set; }

    public decimal CodModoenvio { get; set; }

    public DateTime FecHistorico { get; set; }

    public virtual AcaHincidencium NumIncidenciaNavigation { get; set; } = null!;
}
