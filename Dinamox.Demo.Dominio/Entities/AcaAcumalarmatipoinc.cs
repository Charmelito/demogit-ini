using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAcumalarmatipoinc
{
    public int TipIncidencia { get; set; }

    public DateTime FecPrimera { get; set; }

    public DateTime FecUltima { get; set; }

    public int NumAcumulado { get; set; }

    public virtual AcpTipoincidencium TipIncidenciaNavigation { get; set; } = null!;
}
