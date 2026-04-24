using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoatencion
{
    public decimal CodAtencion { get; set; }

    public string DesAtencion { get; set; } = null!;

    public virtual ICollection<AcpCampanium> AcpCampania { get; set; } = new List<AcpCampanium>();
}
