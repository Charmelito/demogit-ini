using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaIncicampo
{
    public int NumIncidencia { get; set; }

    public int CodCampo { get; set; }

    public decimal IndTipo { get; set; }

    public decimal NumOrden { get; set; }

    public string TipCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual AcpCampo CodCampoNavigation { get; set; } = null!;

    public virtual AcaIncidencium NumIncidenciaNavigation { get; set; } = null!;
}
