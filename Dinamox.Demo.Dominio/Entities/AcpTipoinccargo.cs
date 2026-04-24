using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpTipoinccargo
{
    public int TipIncidencia { get; set; }

    public string CodCalclien { get; set; } = null!;

    public decimal CodProducto { get; set; }

    public decimal CodConcepto { get; set; }

    public string CodMoneda { get; set; } = null!;

    public decimal NumDias { get; set; }

    public decimal NumMaxaltinc { get; set; }

    public decimal ImpCargo { get; set; }

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
