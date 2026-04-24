using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaInicidesviofisico
{
    public decimal CodProceso { get; set; }

    public DateTime FecEntradafis { get; set; }

    public string NomUsuarorafisi { get; set; } = null!;

    public string ObsComentario { get; set; } = null!;
}
