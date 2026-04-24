using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpProcparam
{
    public decimal CodProcsac { get; set; }

    public int CodCampo { get; set; }

    public decimal NumOrden { get; set; }

    public string? NomTabcampo { get; set; }

    public decimal IndTipoparam { get; set; }

    public virtual AcpCampo CodCampoNavigation { get; set; } = null!;

    public virtual AcpProceso CodProcsacNavigation { get; set; } = null!;
}
