using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FluxpProcessFlow
{
    /// <summary>
    /// Identificador del proceso
    /// </summary>
    public int IdProcess { get; set; }

    /// <summary>
    /// Identificador del item del proceso
    /// </summary>
    public int IdProcessItem { get; set; }

    /// <summary>
    /// Identificador del item del proceso siguiente
    /// </summary>
    public int IdProcessItemNext { get; set; }

    /// <summary>
    /// Indicador de activado
    /// </summary>
    public bool IndActivated { get; set; }

    public virtual FluxpProcessItem IdProcessItemNavigation { get; set; } = null!;

    public virtual FluxpProcessItem IdProcessItemNextNavigation { get; set; } = null!;

    public virtual FluxpProcess IdProcessNavigation { get; set; } = null!;
}
