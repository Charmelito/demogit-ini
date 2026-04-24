using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FluxpObjectTypeChidren
{
    /// <summary>
    /// Indicador del sub-tipo de objeto del flujo
    /// </summary>
    public int IdObjectTypeChildren { get; set; }

    /// <summary>
    /// identificador del tipo de objeto del flujo
    /// </summary>
    public int IdObjectType { get; set; }

    /// <summary>
    /// Nombre del sub-tipo de objeto del flujo
    /// </summary>
    public string NomObjectTypeChildren { get; set; } = null!;

    /// <summary>
    /// Descripción del sub-tipo de objeto del flujo
    /// </summary>
    public string DesObjectTypeChildren { get; set; } = null!;

    /// <summary>
    /// Icono
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Indicador de si es final del flujo
    /// </summary>
    public bool IndEnd { get; set; }

    public string? Help { get; set; }

    public virtual ICollection<FluxpProcessItem> FluxpProcessItems { get; set; } = new List<FluxpProcessItem>();

    public virtual FluxpObjectType IdObjectTypeNavigation { get; set; } = null!;
}
