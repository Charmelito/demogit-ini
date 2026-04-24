using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FluxpProcess
{
    /// <summary>
    /// Identificador del proceso
    /// </summary>
    public int IdProcess { get; set; }

    /// <summary>
    /// Nombre del proceso
    /// </summary>
    public string NomProcess { get; set; } = null!;

    /// <summary>
    /// Descripción del proceso
    /// </summary>
    public string DesProcess { get; set; } = null!;

    public virtual ICollection<FluxpProcessFlow> FluxpProcessFlows { get; set; } = new List<FluxpProcessFlow>();
}
