using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCampaniacuest
{
    public short CodCampania { get; set; }

    public string CodCuestionario { get; set; } = null!;

    public decimal NumOrden { get; set; }

    public virtual AcpCampanium CodCampaniaNavigation { get; set; } = null!;

    public virtual AcpCuestionario CodCuestionarioNavigation { get; set; } = null!;
}
