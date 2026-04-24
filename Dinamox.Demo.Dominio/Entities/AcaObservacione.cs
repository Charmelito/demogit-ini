using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaObservacione
{
    public decimal NumIncidencia { get; set; }

    public DateTime FecObservacion { get; set; }

    public string IndIncidencia { get; set; } = null!;

    public string NomUsuarora { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public int CodUsusector { get; set; }

    public int CodIncisector { get; set; }

    public string ObsDetalle { get; set; } = null!;

    public virtual AcpSector CodIncisectorNavigation { get; set; } = null!;

    public virtual AcpSector CodUsusectorNavigation { get; set; } = null!;
}
