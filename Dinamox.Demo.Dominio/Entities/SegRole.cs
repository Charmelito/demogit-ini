using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegRole
{
    /// <summary>
    /// Id único de la regla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre de la regla
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Descripción de para que es la regla
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Indicador de si esta activa
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<SegFieldPermission> SegFieldPermissions { get; set; } = new List<SegFieldPermission>();

    public virtual ICollection<SegMenuPermission> SegMenuPermissions { get; set; } = new List<SegMenuPermission>();

    public virtual ICollection<SegRowsPermission> SegRowsPermissions { get; set; } = new List<SegRowsPermission>();

    public virtual ICollection<SegTablePermission> SegTablePermissions { get; set; } = new List<SegTablePermission>();

    public virtual ICollection<SegUserRole> SegUserRoles { get; set; } = new List<SegUserRole>();
}
