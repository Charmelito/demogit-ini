using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHatencampo
{
    public decimal NumAtencion { get; set; }

    public decimal CodCampo { get; set; }

    public decimal IndTipo { get; set; }

    public DateTime FecHistorico { get; set; }

    public string TipCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual AcaHatencion NumAtencionNavigation { get; set; } = null!;
}
