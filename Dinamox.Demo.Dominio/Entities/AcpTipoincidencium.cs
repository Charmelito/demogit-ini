using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoincidencium
{
    public int TipIncidencia { get; set; }

    public string DesIncidencia { get; set; } = null!;

    public decimal CodTema { get; set; }

    public bool IndSuspendible { get; set; }

    public bool IndComunica { get; set; }

    public bool IndTipincid { get; set; }

    public int CodSector { get; set; }

    public decimal? HorSolucion { get; set; }

    public decimal? HorAlarma { get; set; }

    public bool? IndDesviorapido { get; set; }

    public decimal? CodCausalSspd { get; set; }

    public virtual AcaAcumalarmatipoinc? AcaAcumalarmatipoinc { get; set; }

    public virtual ICollection<AcaAcumcargotipoinc> AcaAcumcargotipoincs { get; set; } = new List<AcaAcumcargotipoinc>();

    public virtual ICollection<AcaBuzonatencion> AcaBuzonatencions { get; set; } = new List<AcaBuzonatencion>();

    public virtual ICollection<AcaIncidencium> AcaIncidencia { get; set; } = new List<AcaIncidencium>();

    public virtual ICollection<AcpRespuestum> AcpRespuesta { get; set; } = new List<AcpRespuestum>();

    public virtual AcpTipoincalarma? AcpTipoincalarma { get; set; }

    public virtual ICollection<AcpTipoinccampo> AcpTipoinccampos { get; set; } = new List<AcpTipoinccampo>();

    public virtual ICollection<AcpTipoinccargo> AcpTipoinccargos { get; set; } = new List<AcpTipoinccargo>();

    public virtual ICollection<AcpTipoincmodenvio> AcpTipoincmodenvios { get; set; } = new List<AcpTipoincmodenvio>();

    public virtual AcpSector CodSectorNavigation { get; set; } = null!;

    public virtual AcpTema CodTemaNavigation { get; set; } = null!;

    public virtual ICollection<AcrPerfil> CodPerfils { get; set; } = new List<AcrPerfil>();
}
