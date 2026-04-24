using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpIntertabla
{
    public short TipInterlocutor { get; set; }

    public string NomTabla { get; set; } = null!;

    public virtual AcpInterlocutor TipInterlocutorNavigation { get; set; } = null!;
}
