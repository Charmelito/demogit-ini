using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaIncidesvio
{
    public int NumIncidencia { get; set; }

    public DateTime FecEntrada { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public int CodSector { get; set; }

    public string NomResponsable { get; set; } = null!;

    public string ObsComentario { get; set; } = null!;

    public decimal? CodProceso { get; set; }

    public virtual AcpSector CodSectorNavigation { get; set; } = null!;

    public virtual AcpUsusac NomUsuaroraNavigation { get; set; } = null!;

    public virtual AcaIncidencium NumIncidenciaNavigation { get; set; } = null!;
}
