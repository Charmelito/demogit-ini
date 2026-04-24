using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaBuzonatencion
{
    public int NumAtencion { get; set; }

    public string NomUsuaroraor { get; set; } = null!;

    public DateTime FecBuzonatencion { get; set; }

    public string? NomUsuarorade { get; set; }

    public int? TipIncidencia { get; set; }

    public int? CodSector { get; set; }

    public string? TipInterlocutor { get; set; }

    public string? CodInterlocutor { get; set; }

    public string? ObsComentario { get; set; }

    public virtual AcpSector? CodSectorNavigation { get; set; }

    public virtual AcpUsusac NomUsuaroraorNavigation { get; set; } = null!;

    public virtual AcaAtencion NumAtencionNavigation { get; set; } = null!;

    public virtual AcpTipoincidencium? TipIncidenciaNavigation { get; set; }
}
