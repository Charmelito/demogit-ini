using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpInterlocutor
{
    public short TipInterlocutor { get; set; }

    public string DesInterlocutor { get; set; } = null!;

    public virtual ICollection<AcaHincidencium> AcaHincidencia { get; set; } = new List<AcaHincidencium>();

    public virtual ICollection<AcaIncidencium> AcaIncidencia { get; set; } = new List<AcaIncidencium>();

    public virtual ICollection<AcpIntertabla> AcpIntertablas { get; set; } = new List<AcpIntertabla>();

    public virtual ICollection<AcpProceso> AcpProcesos { get; set; } = new List<AcpProceso>();
}
