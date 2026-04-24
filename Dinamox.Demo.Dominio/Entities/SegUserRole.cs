using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegUserRole
{
    /// <summary>
    /// Indicador unico del Usuario y la regla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Indicador unico del usuario
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Id único de la regla
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual SegRole Role { get; set; } = null!;

    public virtual SegUser User { get; set; } = null!;
}
