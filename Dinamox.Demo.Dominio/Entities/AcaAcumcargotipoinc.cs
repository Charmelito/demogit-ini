using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAcumcargotipoinc
{
    public int TipIncidencia { get; set; }

    public string TipInterlocutor { get; set; } = null!;

    public string CodInterlocutor { get; set; } = null!;

    public DateTime FecPrimera { get; set; }

    public DateTime FecUltima { get; set; }

    public decimal CodProducto { get; set; }

    public decimal NumAcumulado { get; set; }

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
