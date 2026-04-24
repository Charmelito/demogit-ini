using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAlarmatipoinc
{
    public short TipIncidencia { get; set; }

    public DateTime FecAlarma { get; set; }

    public bool IndMostrar { get; set; }
}
