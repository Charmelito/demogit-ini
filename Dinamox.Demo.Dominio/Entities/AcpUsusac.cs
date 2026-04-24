using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpUsusac
{
    public string NomUsuarora { get; set; } = null!;

    public int CodSector { get; set; }

    public decimal IndConectado { get; set; }

    public string? NomUsuaradmin { get; set; }

    public short? CodCampania { get; set; }

    public decimal? CodCentroAc { get; set; }

    public decimal? IndEnaumail { get; set; }

    public virtual ICollection<AcaAtencion> AcaAtencions { get; set; } = new List<AcaAtencion>();

    public virtual ICollection<AcaBuzonatencion> AcaBuzonatencions { get; set; } = new List<AcaBuzonatencion>();

    public virtual ICollection<AcaIncidencium> AcaIncidencia { get; set; } = new List<AcaIncidencium>();

    public virtual ICollection<AcaIncidesvio> AcaIncidesvios { get; set; } = new List<AcaIncidesvio>();

    public virtual ICollection<AcpTipoincalarma> AcpTipoincalarmas { get; set; } = new List<AcpTipoincalarma>();

    public virtual AcrPerfilususac? AcrPerfilususac { get; set; }

    public virtual AcpCampanium? CodCampaniaNavigation { get; set; }

    public virtual AcpSector CodSectorNavigation { get; set; } = null!;
}
