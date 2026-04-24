using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FluxpProcessItem
{
    /// <summary>
    /// Identificador del item del proceso
    /// </summary>
    public int IdProcessItem { get; set; }

    /// <summary>
    /// Indicador del sub-tipo de objeto del flujo
    /// </summary>
    public int IdObjectTypeChildren { get; set; }

    /// <summary>
    /// Nombre del item del proceso
    /// </summary>
    public string NomProcessItem { get; set; } = null!;

    /// <summary>
    /// Descripción del item del proceso
    /// </summary>
    public string DesProcessItem { get; set; } = null!;

    /// <summary>
    /// Indicador de si sus salidas son opcionales
    /// </summary>
    public bool IndOptionalExit { get; set; }

    public virtual ICollection<FluxpProcessFlow> FluxpProcessFlowIdProcessItemNavigations { get; set; } = new List<FluxpProcessFlow>();

    public virtual ICollection<FluxpProcessFlow> FluxpProcessFlowIdProcessItemNextNavigations { get; set; } = new List<FluxpProcessFlow>();

    public virtual FluxpObjectTypeChidren IdObjectTypeChildrenNavigation { get; set; } = null!;
}
