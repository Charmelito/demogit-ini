using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCampanium
{
    public short CodCampania { get; set; }

    public string DesCampania { get; set; } = null!;

    public decimal CodAtencion { get; set; }

    public bool IndHistorico { get; set; }

    public bool IndEnviomail { get; set; }

    public virtual ICollection<AcaAtencion> AcaAtencions { get; set; } = new List<AcaAtencion>();

    public virtual ICollection<AcpCampaniacuest> AcpCampaniacuests { get; set; } = new List<AcpCampaniacuest>();

    public virtual ICollection<AcpUsusac> AcpUsusacs { get; set; } = new List<AcpUsusac>();

    public virtual AcpTipoatencion CodAtencionNavigation { get; set; } = null!;

    public virtual ICollection<AcrPerfil> CodPerfils { get; set; } = new List<AcrPerfil>();
}
