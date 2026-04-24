using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoinccampo
{
    public int TipIncidencia { get; set; }

    public int CodCampo { get; set; }

    public decimal IndTipo { get; set; }

    public decimal NumOrden { get; set; }

    public virtual AcpCampo CodCampoNavigation { get; set; } = null!;

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
