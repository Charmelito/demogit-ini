using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCamposBase
{
    public string CodTablaBase { get; set; } = null!;

    public decimal CodCampoWhere { get; set; }

    public string DesCampoWhere { get; set; } = null!;
}
