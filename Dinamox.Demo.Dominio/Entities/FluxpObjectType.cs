using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Tipo de objeto del flujo
/// </summary>
public partial class FluxpObjectType
{
    /// <summary>
    /// identificador único del tipo de objeto del flujo
    /// </summary>
    public int IdObjectType { get; set; }

    /// <summary>
    /// Nombre del tipo de objeto del flujo
    /// </summary>
    public string NomObjectType { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de objeto del flujo
    /// </summary>
    public string DesObjectType { get; set; } = null!;

    /// <summary>
    /// Icono a presentar para el tipo de objeto
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Ayuda para el tipo de objeto
    /// </summary>
    public string? Help { get; set; }

    public virtual ICollection<FluxpObjectTypeChidren> FluxpObjectTypeChidrens { get; set; } = new List<FluxpObjectTypeChidren>();
}
