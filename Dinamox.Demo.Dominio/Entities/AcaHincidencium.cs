using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHincidencium
{
    public decimal NumIncidencia { get; set; }

    public short TipInterlocutor { get; set; }

    public decimal TipIncidencia { get; set; }

    public decimal NumAtencion { get; set; }

    public string NomUsuaroracr { get; set; } = null!;

    public DateTime FecCreacion { get; set; }

    public DateTime FecEstimada { get; set; }

    public string CodEstado { get; set; } = null!;

    public string IndTratamiento { get; set; } = null!;

    public DateTime FecHistorico { get; set; }

    public string? CodInterlocutor { get; set; }

    public string? TipInter { get; set; }

    public DateTime? FecAlarma { get; set; }

    public DateTime? FecReal { get; set; }

    public string? NomUsuaroraso { get; set; }

    public DateTime? FecComunica { get; set; }

    public string? NomUsuaroraco { get; set; }

    public string? ObsComentario { get; set; }

    public DateTime? FecRompimiento { get; set; }

    public DateTime? FecImpresion { get; set; }

    public string? NomUsuarorarom { get; set; }

    public decimal? TipSolucion { get; set; }

    public decimal? CodCentroAc { get; set; }

    public decimal? CodSectordesv { get; set; }

    public virtual ICollection<AcaHincicampo> AcaHincicampos { get; set; } = new List<AcaHincicampo>();

    public virtual ICollection<AcaHincidesvio> AcaHincidesvios { get; set; } = new List<AcaHincidesvio>();

    public virtual ICollection<AcaHincidoc> AcaHincidocs { get; set; } = new List<AcaHincidoc>();

    public virtual AcpInterlocutor TipInterlocutorNavigation { get; set; } = null!;
}
