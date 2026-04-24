using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoincalarma
{
    public int TipIncidencia { get; set; }

    public string DesMensaje { get; set; } = null!;

    public decimal NumDias { get; set; }

    public decimal NumMaxaltinc { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public virtual AcpUsusac NomUsuaroraNavigation { get; set; } = null!;

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
