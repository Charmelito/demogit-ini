using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTema
{
    public decimal CodTema { get; set; }

    public string DesTema { get; set; } = null!;

    public int CodSector { get; set; }

    public virtual ICollection<AcpTipoincidencium> AcpTipoincidencia { get; set; } = new List<AcpTipoincidencium>();

    public virtual AcpSector CodSectorNavigation { get; set; } = null!;
}
