using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcrRestradocumento
{
    public int CodPerfil { get; set; }

    public decimal CodDocmaestro { get; set; }

    public virtual AcrPerfil CodPerfilNavigation { get; set; } = null!;
}
