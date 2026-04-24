using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpNovedad
{
    public decimal CodNovedad { get; set; }

    public string DesNovedad { get; set; } = null!;

    public string ObsNovedad { get; set; } = null!;

    public int CodSector { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecFinal { get; set; }

    public virtual AcpSector CodSectorNavigation { get; set; } = null!;
}
