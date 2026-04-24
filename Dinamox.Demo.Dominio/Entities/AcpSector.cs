using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpSector
{
    public int CodSector { get; set; }

    public string DesSector { get; set; } = null!;

    public string? CodOficina { get; set; }

    public bool IndCanal { get; set; }

    public string NomResponsable { get; set; } = null!;

    public virtual ICollection<AcaBuzonatencion> AcaBuzonatencions { get; set; } = new List<AcaBuzonatencion>();

    public virtual ICollection<AcaIncidencium> AcaIncidencia { get; set; } = new List<AcaIncidencium>();

    public virtual ICollection<AcaIncidesvio> AcaIncidesvios { get; set; } = new List<AcaIncidesvio>();

    public virtual ICollection<AcaObservacione> AcaObservacioneCodIncisectorNavigations { get; set; } = new List<AcaObservacione>();

    public virtual ICollection<AcaObservacione> AcaObservacioneCodUsusectorNavigations { get; set; } = new List<AcaObservacione>();

    public virtual ICollection<AcpNovedad> AcpNovedads { get; set; } = new List<AcpNovedad>();

    public virtual ICollection<AcpTema> AcpTemas { get; set; } = new List<AcpTema>();

    public virtual ICollection<AcpTipoincidencium> AcpTipoincidencia { get; set; } = new List<AcpTipoincidencium>();

    public virtual ICollection<AcpUsusac> AcpUsusacs { get; set; } = new List<AcpUsusac>();
}
