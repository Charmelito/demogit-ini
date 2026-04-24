using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaIncidencium
{
    public int NumIncidencia { get; set; }

    public short TipInterlocutor { get; set; }

    public int TipIncidencia { get; set; }

    public int NumAtencion { get; set; }

    public string NomUsuaroracr { get; set; } = null!;

    public DateTime FecCreacion { get; set; }

    public DateTime FecEstimada { get; set; }

    public string CodEstado { get; set; } = null!;

    public string IndTratamiento { get; set; } = null!;

    public string? CodInterlocutor { get; set; }

    public string? TipInter { get; set; }

    public DateTime? FecAlarma { get; set; }

    public DateTime? FecReal { get; set; }

    public string? NomUsuaroraso { get; set; }

    public DateTime? FecComunica { get; set; }

    public string? NomUsuaroraco { get; set; }

    public string? CodEstadoant { get; set; }

    public int? CodSectordesv { get; set; }

    public string? ObsComentario { get; set; }

    public DateTime? FecRompimiento { get; set; }

    public DateTime? FecImpresion { get; set; }

    public string? NomUsuarorarom { get; set; }

    public decimal? TipSolucion { get; set; }

    public decimal? CodCentroAc { get; set; }

    public virtual AcaAlarmanosol? AcaAlarmanosol { get; set; }

    public virtual ICollection<AcaIncicampo> AcaIncicampos { get; set; } = new List<AcaIncicampo>();

    public virtual ICollection<AcaIncidesvio> AcaIncidesvios { get; set; } = new List<AcaIncidesvio>();

    public virtual ICollection<AcaIncidoc> AcaIncidocs { get; set; } = new List<AcaIncidoc>();

    public virtual AcpSector? CodSectordesvNavigation { get; set; }

    public virtual AcpUsusac NomUsuaroracrNavigation { get; set; } = null!;

    public virtual AcaAtencion NumAtencionNavigation { get; set; } = null!;

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;

    public virtual AcpInterlocutor TipInterlocutorNavigation { get; set; } = null!;
}
