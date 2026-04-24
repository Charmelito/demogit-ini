using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpModoenvio
{
    public short CodModoenvio { get; set; }

    public string DesModoenvio { get; set; } = null!;

    public virtual ICollection<AcaAtendoc> AcaAtendocs { get; set; } = new List<AcaAtendoc>();

    public virtual ICollection<AcaIncidoc> AcaIncidocs { get; set; } = new List<AcaIncidoc>();

    public virtual ICollection<AcpTipoincmodenvio> AcpTipoincmodenvios { get; set; } = new List<AcpTipoincmodenvio>();
}
