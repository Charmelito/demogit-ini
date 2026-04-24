using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipodocumento
{
    public short TipDocumento { get; set; }

    public string DesDocumento { get; set; } = null!;

    public decimal? CodProcsac { get; set; }

    public virtual ICollection<AcaAtendoc> AcaAtendocs { get; set; } = new List<AcaAtendoc>();

    public virtual ICollection<AcaIncidoc> AcaIncidocs { get; set; } = new List<AcaIncidoc>();

    public virtual ICollection<AcpTipoincmodenvio> AcpTipoincmodenvios { get; set; } = new List<AcpTipoincmodenvio>();

    public virtual AcpProceso? CodProcsacNavigation { get; set; }
}
