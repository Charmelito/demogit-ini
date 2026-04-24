using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAtendoc
{
    public int NumAtencion { get; set; }

    public short TipDocumento { get; set; }

    public bool IndTipo { get; set; }

    public short CodModoenvio { get; set; }

    public virtual AcpModoenvio CodModoenvioNavigation { get; set; } = null!;

    public virtual AcaAtencion NumAtencionNavigation { get; set; } = null!;

    public virtual AcpTipodocumento TipDocumentoNavigation { get; set; } = null!;
}
