using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoincmodenvio
{
    public short CodModoenvio { get; set; }

    public short TipDocumento { get; set; }

    public int TipIncidencia { get; set; }

    public bool IndTipo { get; set; }

    public virtual AcpModoenvio CodModoenvioNavigation { get; set; } = null!;

    public virtual AcpTipodocumento TipDocumentoNavigation { get; set; } = null!;

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
