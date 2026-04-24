using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHincidesvio
{
    public decimal NumIncidencia { get; set; }

    public DateTime FecEntrada { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public decimal CodSector { get; set; }

    public string NomResponsable { get; set; } = null!;

    public string ObsComentario { get; set; } = null!;

    public DateTime FecHistorico { get; set; }

    public decimal? CodProceso { get; set; }

    public virtual AcaHincidencium NumIncidenciaNavigation { get; set; } = null!;
}
