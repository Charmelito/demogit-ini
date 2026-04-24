using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHincicampo
{
    public decimal NumIncidencia { get; set; }

    public decimal CodCampo { get; set; }

    public decimal NumOrden { get; set; }

    public decimal IndTipo { get; set; }

    public string TipCampo { get; set; } = null!;

    public DateTime FecHistorico { get; set; }

    public string? ValCampo { get; set; }

    public virtual AcaHincidencium NumIncidenciaNavigation { get; set; } = null!;
}
