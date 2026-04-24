using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcrPerfilususac
{
    public string NomUsuarora { get; set; } = null!;

    public int CodPerfilcamp { get; set; }

    public int CodPerfiltinc { get; set; }

    public virtual AcrPerfil CodPerfilcampNavigation { get; set; } = null!;

    public virtual AcrPerfil CodPerfiltincNavigation { get; set; } = null!;

    public virtual AcpUsusac NomUsuaroraNavigation { get; set; } = null!;
}
