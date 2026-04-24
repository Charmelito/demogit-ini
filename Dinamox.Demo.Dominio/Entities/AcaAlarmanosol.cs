using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAlarmanosol
{
    public int NumIncidencia { get; set; }

    public bool IndMostrar { get; set; }

    public bool IndReclamo { get; set; }

    public virtual AcaIncidencium NumIncidenciaNavigation { get; set; } = null!;
}
