using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaIncidoc
{
    public int NumIncidencia { get; set; }

    public short TipDocumento { get; set; }

    public decimal IndTipo { get; set; }

    public decimal NumOrden { get; set; }

    public short CodModoenvio { get; set; }

    public virtual AcpModoenvio CodModoenvioNavigation { get; set; } = null!;

    public virtual AcaIncidencium NumIncidenciaNavigation { get; set; } = null!;

    public virtual AcpTipodocumento TipDocumentoNavigation { get; set; } = null!;
}
